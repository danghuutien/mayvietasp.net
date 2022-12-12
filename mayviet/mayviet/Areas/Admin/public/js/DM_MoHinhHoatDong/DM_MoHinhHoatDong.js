/// <reference path="../danhmuc/danhmuc.js" />

var vm = new Vue({
    el: '#demo',
    data: {
        datatb: {
            // Tên các cột có thẻ search
            searchcolum: [
                'name'
            ],
            // đường dẫn đến ajax
            url: '/Admin/DM_MoHinhHoatDong/Ajax',
            // Số bản ghi trên 1 trang
            length: 10,

            // Biến tìm kiếm
            searchnow: '',
            // Số trang
            total: '',
            // Dữ liệu danh sách bảng

            // Trang hiện tại đang ở
            paginatenow: 1,
        },
        rowId: '',
        statusForm: '',
        dataForm: form({
            Name: '',
            
            
        })
            .rules({
                TenMoHinhHoatDong: 'required',

            })
            .messages({
                'TenMoHinhHoatDong.required': 'Trường bắt buộc nhập',
            }),

        isActivemodal: true,
        /*titlename: '',*/
        data: {
            tableData: Array(),
            total: '',
            paginatenow:1
        },
        
    },
    watch: {
        /*titlename(data) {
            this.dataForm.name = data;
            this.ChangeToSlug(data);
            console.log(this.dataForm.data.name)
        }*/
    },
    mounted: function () {
        this.loadData();
        const self = this;

        
    },
    methods: {

        onChange(event) {
            // Gán lại trang hiện tại là 1 và gán lại giá trị searchnow ( biến dùng để tìm kiếm)
            /*this.datatb.paginatenow = 1;*/
            this.datatb.searchnow = event.target.value;
            console.log(this.datatb.searchnow)
            // Load lại bảng
            this.loadData();
        },

       
        openmodal() {
            
            
            this.isActivemodal = false;
        },

        closemodal() {
            this.isActivemodal = true;
            this.dataForm.errors().messages = {};
        },
        saveform() {
            
            this.dataForm.TenMoHinhHoatDong = '';
            

            this.statusForm = "insert";
            this.openmodal();
        },
        submitform() {
            if (this.dataForm.validate().errors().any()) {
                return;
            }
            const self = this;
            this.closemodal()
            console.log(self.dataForm.data);
            if (this.statusForm == "insert") {
                axios.post("/Admin/DM_MoHinhHoatDong/Create", self.dataForm.data).then(function (response) {
                    self.thongbaothanhcong('Lưu thành công')
                    self.loadData();
                })
                    .catch(error => {
                        self.thongbaothatbai(error);
                    });
            } else {
                console.log(self.rowId)
                axios.post("/Admin/DM_MoHinhHoatDong/Edit",
                    {
                        id: self.rowId,
                        TenMoHinhHoatDong: self.dataForm.data.TenMoHinhHoatDong,
                    }
                )
                    .then(function (response) {
                        self.thongbaothanhcong('Sửa thành công')
                        self.loadData();
                    })
                    .catch(error => {
                        self.thongbaothatbai(error);
                    });
            }

        },
        pagination(data) {
            /*console.log(data)*/
            // Gán lại giá trị paginatenow
            this.data.paginatenow = data;
            // Load lại bảng
            this.loadData();
            /*console.log(this.datatb.start)*/
        },
        // load lại dữ liệu
        loadData() {
            const self = this;
            // Lấy index bản ghi bắt đầu
            var start = this.datatb.length * (this.data.paginatenow - 1);
            console.log(start)
            this.datatb.start = start;
            // Ajax dữ liệu
            axios.post(self.datatb.url, {
                start: this.datatb.start,
                length: this.datatb.length,
                searchnow: this.datatb.searchnow,
                // Đẩy dữ liệu lên controller
                
            })
                .then(function (response) {
                    // Tổng số trang hiện có
                    self.data.tableData = response.data.data;
                    console.log(response.data)


                    self.data.total = Math.ceil(
                        response.data.recordsTotal / 10
                    );
                    /*console.log(response.data)*/
                    // Dữ liệu bảng



                });
        },
        //data table
        doAlertEdit(data) {
            const self = this;
            // Gán giá trị cho form

            self.dataForm.TenMoHinhHoatDong = data.TenMoHinhHoatDong;
            
            

            // Sửa tình trạng form
            this.statusForm = "update";
            this.rowId = data.Id;
            this.openmodal('sua');
        },
        doAlertDelete(data) {
            const self = this;
            this.$confirm('Thao tác này không thể quay lại, bạn chắc chắn tiếp tục?', 'Cảnh báo', {
                confirmButtonText: 'Vâng, xóa nó!',
                cancelButtonText: 'Không xóa!',
                type: 'warning',
                center: true
            }).then(() => {
                axios.post("/Admin/DM_MoHinhHoatDong/Delete", data)
                    .then(function (response) {
                        self.loadData();
                        console.log(response.data.status)
                        if (response.data.status) {
                            self.$message({
                                type: 'success',
                                message: 'Xóa thành công'
                            });
                        } else {

                            self.thongbaothatbai("Không thể xóa bản ghi này")
                        }
                    })
                    .catch(function (error) {
                        // Thông báo xóa thất bại
                        self.thongbaothatbai(error)
                    });
                // this.$message({
                //     type: 'success',
                //     message: 'Xóa thành công'
                // });

            }).catch(() => {
                this.$message({
                    type: 'info',
                    message: 'Đã hủy xóa'
                });
            });


        },
        doAfterReload(data, table) {
            window.alert('data reloaded')
        },
        doCreating(comp, el) {
            console.log('creating')
        },
        doCreated(comp) {
            console.log('created')
        },
        doExport(type) {
            const parms = this.$refs.table.getServerParams()
            parms.export = type
            window.alert('GET /api/v1/export?' + jQuery.param(parms))
        },
        thongbaothanhcong(text) {
            this.$notify({
                title: 'Success',
                message: text,
                type: 'success'
            });
        },
        thongbaothatbai(text) {
            this.$notify.error({
                title: 'Error',
                message: text
            });

        },
    }
})
