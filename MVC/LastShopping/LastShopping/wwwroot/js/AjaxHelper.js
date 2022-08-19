//#region AjaxHelper [ Ajax API呼叫 ]
var AjaxHelper = (function () {
    /**
     * 預設錯誤處理
     * @param {any} _msg
     */
    let DefaultErrorCtrl = (_errors) => {
        var _msg = [];
        if (Array.isArray(_errors)) {
            _msg = _errors;
        } else {
            for (let i in _errors) {
                _msg.push(
                    _errors[i]
                        .map((x) => {
                            if (
                                x.indexOf(
                                    "Could not convert string to DateTime"
                                ) < 0
                            )
                                return x;
                            return "日期資料格式輸入錯誤";
                        })
                        .join("、")
                );
            }
        }
        UiHelper.showErr(_msg);
    };

    return {
        //#region get [ 呼叫ajax get ]
        /**
         * ajax get
         * @param {object} _cfg - ajax設定物件
         * @param {string} _cfg.url 呼叫連結
         * @param {string} _cfg.ApiDesc 服務描述
         * @param {Object} _cfg.data 傳遞物件
         * @param {function} _cfg.success 成功時呼叫函數
         * @param {function} _cfg.fail 失敗時呼叫函數
         * @returns {void}
         */
        get: (_cfg) => {
            UiHelper.blockUI();
            UiHelper.clearMsg();
            // 連結後端 API
            $.ajax({
                // 請求方式: 讀取
                type: "Get",
                // 查詢燈號預警資料，篩選 年分
                url: _cfg.url,
                // 若需要使用ajax取得的result的數值，必須設定為false(才會變成sync同步執行）
                //async: false,
                // 設置為false將不會從瀏覽器緩存中加載請求信息。
                cache: false,
                data: _cfg.data,
                // 預期服務器返回的數據類型。
                dataType: "json",
                // 當發送的數據格式為json時，設置的編碼類型為："application/json; charset=utf-8"
                contentType: "application/json",
                // 要求為Function類型的參數，請求成功後調用的回調函數，有兩個參數。
                success: (data) => {
                    // 返回一個布爾值，指示對像是否將指定的屬性作為自己的屬性
                    const result = data.hasOwnProperty("d") ? data.d : data;

                    // 判斷是否有資料
                    if (_cfg.success) {
                        _cfg.success(result); // 傳遞資料
                    }
                },
                // 請求失敗時被調用的函數
                error: (XMLHttpRequest, textStatus, errorThrown) => {
                    // 判斷 是否設定 showErr內容
                    if (_cfg.fail) {
                        _cfg.fail();
                    }
                    // 判斷 狀態等於 400
                    else if (XMLHttpRequest.status === 400) {
                        DefaultErrorCtrl(XMLHttpRequest.readyState);
                        return;
                    } else {
                        UiHelper.showErr(
                            _cfg.ApiDesc
                                ? `${_cfg.ApiDesc}服務呼叫異常`
                                : "服務呼叫異常" // 判斷是否有設定 服務描述
                        );
                        console.debug(errorThrown); // 偵錯環境使用
                    }
                },
                // 無論成功與否皆會執行
                complete: () => {
                    UiHelper.unBlockUI();
                },
            });
        },
        //#endregion
        //#region post [ 呼叫ajax post ]
        /**
         * ajax post
         * @param {object} _cfg - ajax設定物件
         * @param {Object} _cfg.data 傳遞物件
         * @param {string} _cfg.method HTTP方式
         * @param {string} _cfg.url 呼叫連結
         * @param {string} _cfg.ApiDesc 服務描述
         * @param {boolean} _cfg.contentType 傳遞類別
         * @param {function} _cfg.success 成功時呼叫函數
         * @param {function} _cfg.fail 失敗時呼叫函數
         * @returns {void}
         */
        method: (_cfg) => {
            _cfg.contentType = _cfg.contentType === undefined ? "application/x-www-form-urlencoded; charset=UTF-8" : "application/json; charset=UTF-8";

            UiHelper.blockUI();
            UiHelper.clearMsg();
            // 連結後端 API
            $.ajax({
                // 請求方式: 更新
                type: _cfg.method,
                // 更新查詢燈號預警資料，篩選 oid
                url: _cfg.url,
                // 若需要使用ajax取得的result的數值，必須設定為false(才會變成sync同步執行）
                //async: false,
                // 設置為false將不會從瀏覽器緩存中加載請求信息。
                cache: false,
                // 發送到服務器的數據，例：{foo1:"bar1",foo2:"bar2"}轉換為&foo1=bar1&foo2=bar2
                data: _cfg.data,
                // 預期服務器返回的數據類型。
                dataType: "json",
                // 當發送的數據格式為json時，設置的編碼類型為："application/json; charset=utf-8"
                contentType: _cfg.contentType,
                // 要求為Function類型的參數，發送請求前可以修改XMLHttpRequest對象的函數，例如添加自定義HTTP頭
                beforeSend: (xhr) => {
                    let _csrf = $('input:hidden[name="__RequestVerificationToken"]');

                    if (_csrf) {
                        // 設置 HTTP 的表頭請求
                        xhr.setRequestHeader(
                            "RequestVerificationToken",
                            _csrf.val()
                        );
                    }
                },
                // 要求為Function類型的參數，請求成功後調用的回調函數，有兩個參數。
                success: (data) => {
                    // 返回一個布爾值，指示對像是否將指定的屬性作為自己的屬性
                    const result = data.hasOwnProperty("d") ? data.d : data;

                    // 判斷是否有資料
                    if (_cfg.success) {
                        _cfg.success(result);
                    }
                },
                // 請求失敗時被調用的函數
                error: (XMLHttpRequest, textStatus, errorThrown) => {
                    // 判斷 是否設定 showErr內容
                    if (_cfg.fail) {
                        _cfg.fail();
                    }
                    // 判斷 狀態等於 400
                    else if (XMLHttpRequest.status === 400) {
                        DefaultErrorCtrl(error.response.data.errors);
                        return;
                    } else {
                        UiHelper.showErr(
                            _cfg.ApiDesc
                                ? `${_cfg.ApiDesc}服務呼叫異常`
                                : "服務呼叫異常" // 判斷是否有設定 服務描述
                        );
                        console.debug(errorThrown); // 偵錯環境使用
                    }
                },
                // 無論成功與否皆會執行
                complete: () => {
                    UiHelper.unBlockUI();
                },
            });
        },
    };
})();
//#endregion