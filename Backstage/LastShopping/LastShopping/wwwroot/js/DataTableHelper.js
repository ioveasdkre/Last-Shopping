//分頁排序等功能
const DataTableHelper = (function () {
    return {
        getDataTable(_cfg) {
            console.log(_cfg);
            console.log("我有改變嗎");
            $(`#${_cfg.tableName}`).DataTable({
                searching: false, //關閉搜尋功能
                oLanguage: {
                    // 中文化
                    sLengthMenu: "每頁顯示 _MENU_筆",
                    sZeroRecords: "請設定搜尋條件 或 沒有找到符合條件的資料",
                    sProcessing: "載入中...",
                    sInfo: "當前第 _START_ - _END_ 筆　共計 _TOTAL_ 筆",
                    sInfoEmpty: "沒有記錄",
                    sInfoFiltered: "(從 _MAX_ 條記錄中過濾)",
                    sSearch: "搜尋：",
                    oPaginate: {
                        sFirst: "首頁",
                        sPrevious: "前一頁",
                        sNext: "後一頁",
                        sLast: "尾頁",
                    },
                },
                iDisplayLength: 25, // 每頁顯示筆數
                // 下拉式選單 每頁顯示幾筆
                lengthMenu: [
                    [5, 10, 25, 50, -1],
                    [5, 10, 25, 50, "All"],
                ],
                bSort: true, // 排序
                columnDefs: [
                    {
                        targets: _cfg.targets, //不進行排序功能的欄位
                        orderable: false, // 不進行排序功能
                    },
                    {
                        className: "dt-head-center",
                        targets: "_all"
                    }
                ],
            });
        },
    };
})();