<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GridViewUI.aspx.cs" Inherits="HFunctionLibrary.GridViewUI" %>
<html>
<head>
    <title>jqgrid</title>
    <script src="Scripts/jquery-3.3.1.js"></script>
    <script src="Scripts/jquery.jqGrid.js"></script>
    <script src="Scripts/jquery-ui-1.12.1.js"></script>
    <script src="Scripts/i18n/grid.locale-en.js"></script>

    <link href="Content/jquery.jqGrid/ui.jqgrid.css" rel="stylesheet" />
    <link href="Content/themes/base/jquery-ui.css" rel="stylesheet" />

    <script type="text/javascript">
        jQuery(document).ready(function () {
 
        $.ajax({
            type: "POST",
            contentType: "application/json",
            jsonReader: {
                repeatitems: false
            },
            url: "WebServiceTable.asmx/GetListOfPersons",
            data: "{}",
            dataType: 'json',
            success: function (result) {
                var result = $.parseJSON(result.d);
                for (var i = 0; i <= result.length; i++)
                {
                    jQuery("#tabPeopleList").jqGrid('addRowData', i + 1, result[i]);
                }
            },
            error: function (msg) {
                alert('fail');
            }
        });

        jQuery("#tabPeopleList").jqGrid({
            colNames: ['使用者編號', '使用者名稱', '真實名稱', '註記'],
            colModel: [
                { name: 'UserID', label: '使用者編號', width: 40, align: 'left' },
                { name: 'UserName', label: '使用者名稱', width: 40, align: 'left' },
                { name: 'RealName', label: '真實名稱', width: 40, align: 'left' },
                { name: 'Comments', label: '註記', width: 40, align: 'left' },
            ],
            autowidth: true,
            rowNum: 10,
            rowList: [10, 20, 30],
            pager: '#pager',
            sortname: 'docid',
            viewrecords: true,
            sortorder: "desc",
            caption: "我的第一個jqgrid出不來",
            height: '100%'
        });
    });
</script>
</head>

<body>
    <table id="tabPeopleList"></table>
    <div id="pager"></div>
</body>

</html>
