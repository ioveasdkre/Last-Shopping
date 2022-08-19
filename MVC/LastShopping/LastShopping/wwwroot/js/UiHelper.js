//#region UiHelper [ sweetalert2 彈跳視窗 ]
var UiHelper = ((MySwal) => {
    return {
        //#region GetUrlParameter [ 取得 QueryString 中參數) ]
        /**
         * 取得 QueryString 中參數
         * @param {any} parameterName 參數名稱
         * @returns {any} 取得的參數值
         */
        GetUrlParameter: (parameterName) => {
            var result = null,
                tmp = [];
            var items = location.search.substr(1).split("&");
            for (let x of items) {
                tmp = x.split("=");
                if (tmp[0] === parameterName)
                    result = decodeURIComponent(tmp[1]);
            }
            return result;
        },
        //#endregion
        //#region GetFile [ 檔案上傳前端JS判讀 ]
        /**
         * 檔案上傳前端JS判讀
         * @param {any} file 上傳物件
         * @param {any} callfn 檔案取完成 call back 函數
         */
        GetFile: (file, callfn) => {
            var reader = new FileReader();
            reader.onload = (e) => {
                var f = {
                    name: file.name,
                    size: file.size,
                    body: e.target.result.split(",")[1],
                    mimetype: e.target.result.split(";")[0].split(":")[1],
                };
                if (callfn) callfn(f);
            };
            reader.readAsDataURL(file);
        },
        //#endregion
        //#region blockUI [ 遮罩目前操作畫面) ]
        /**
         * 遮罩目前操作畫面
         * @param {any} _msg 自訂遮罩時使用文字
         */
        blockUI: (messages) => {
            this.blockSwal = MySwal.fire({
                icon: "info",
                title: messages || "資料處理中，請稍後...",
                backdrop: true,
                showConfirmButton: false,
                didOpen: () => {
                    Swal.showLoading();
                },
                didDestroy: () => {
                    Swal.hideLoading();
                },
            });
        },
        //#endregion
        //#region unBlockUI [ 關閉畫面遮罩) ]
        /** 關閉畫面遮罩 */
        unBlockUI: () => {
            if (this.blockSwal) {
                this.blockSwal.close();
            }
        },
        //#endregion
        //#region clearMsg [ 清空全部浮動訊息) ]
        /** 清空全部浮動訊息
         * @returns {any} UiHelper
         */
        clearMsg: () => {
            return this;
        },
        //#endregion
        //#region timerMsg [ 計時提示訊息) ]
        /**
         * 計時提示訊息
         * @param {any} messages 訊息內容
         * @param {any} wait 訊息停留秒數
         */
        timerMsg: (messages, wait) => {
            if (typeof wait === "undefined") wait = 3;
            var _msg = "";
            if (typeof messages === "string") {
                _msg = messages;
            } else if (messages && messages.length > 0) {
                _msg =
                    "<ul style='padding-left:1em;'><li>" +
                    messages.join("</li><li>") +
                    "</li></ul>";
            }
            if (!_msg) return;

            MySwal.fire({
                position: "top-end",
                icon: "success",
                html: _msg,
                showConfirmButton: false,
                showCloseButton: true,
                timerProgressBar: true,
                toast: true,
                timer: wait * 1000,
            });
        },
        //#endregion
        //#region showErr [ 計時錯誤訊息) ]
        /**
         * 計時錯誤訊息
         * @param {any} messages 訊息內容
         * @param {any} wait 訊息停留秒數
         */
        showErr: (messages, wait) => {
            if (typeof wait === "undefined") wait = 10;
            var _msg = "";
            if (typeof messages === "string") {
                _msg = messages;
            } else if (messages && messages.length > 0) {
                _msg =
                    "<ul style='padding-left:1em;'><li>" +
                    messages.join("</li><li>") +
                    "</li></ul>";
            }
            if (!_msg) return;
            MySwal.fire({
                position: "top-end",
                icon: "warning",
                html: _msg,
                showConfirmButton: false,
                showCloseButton: true,
                timerProgressBar: true,
                toast: true,
                timer: wait * 1000,
            });
        },
        //#endregion
        //#region showMgs [ 顯示提示訊息) ]
        /**
         * 提示訊息
         * @param {any} messages 訊息內容
         * @param {any} func callback function
         */
        showMgs: (messages, func) => {
            MySwal.fire({
                icon: "info",
                html: messages,
                showConfirmButton: true,
                confirmButtonColor: "#2351e8",
            }).then((result) => {
                if (result.isConfirmed && func) {
                    func();
                }
            });
        },
        //#endregion
        //#region showErr [ 顯示錯誤訊息) ]
        /**
         * 顯示錯誤訊息
         * @param {any} messages 訊息內容
         * @param {any} func callback function
         */
        showErr: (messages, func) => {
            MySwal.fire({
                icon: "warning",
                html: messages,
                showConfirmButton: true,
                confirmButtonColor: "#2351e8",
            }).then((result) => {
                if (result.isConfirmed && func) {
                    func();
                }
            });
        },
        //#endregion
        //#region [ 確認提示訊息) ]
        /**
         * 確認提示訊息
         * @param {any} message 提示訊息
         * @param {any} onOk 確認時處理事件
         * @param {any} onCancel 取消時處理事件
         */
        confirm: (message, onOk, onCancel) => {
            MySwal.fire({
                icon: "warning",
                html: message,
                showConfirmButton: true,
                showCancelButton: true,
            }).then((result) => {
                if (result.isConfirmed && onOk) {
                    onOk();
                }
                if (result.isDismissed && onCancel) {
                    onCancel();
                }
            });
        },
        //#endregion
    };
})(
    Swal.mixin({
        title: "提示訊息",
        closeButtonAriaLabel: "關閉訊息",
        confirmButtonText: "確認",
        confirmButtonAriaLabel: "確認",
        denyButtonText: "拒絕",
        denyButtonAriaLabel: "拒絕",
        cancelButtonText: "取消",
        cancelButtonAriaLabel: "取消",
    })
);
//#endregion