﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GridViewUI.aspx.cs" Inherits="HFunctionLibrary.GridViewUI" %>

    <script src="Scripts/jquery-3.3.1.js"></script>
    <script src="Scripts/jquery.jqGrid.js"></script>
    <script src="Scripts/jquery-ui-1.12.1.js"></script>
    <link href="Content/jquery.jqGrid/ui.jqgrid.css" rel="stylesheet" />
    <link href="Content/themes/base/jquery-ui.css" rel="stylesheet" />

<script type="text/javascript">
    $(function () {
        $("#table").jqGrid({
            datatype: function (pdata) { getData(pdata); },
            height: 'auto',
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
            imgpath: '<%= ResolveClientUrl("~/styles/redmon/images") %>',
            caption: "我的第一個jqgrid"
        });
    });

    function getData(pData) {
        $.ajax({
            type: 'POST',
            contentType: "application/json; charset=utf-8",
            url: '<%= ResolveClientUrl("~/WebServiceTable.asmx/GetListOfPersons") %>',
            data: '{}',
            dataType: "json",
            success: function (data, textStatus) {
                if (textStatus == "success")
                {
                    ReceivedClientData(JSON.parse(getMain(data)).rows);
                }
            },
            error: function (data, textStatus) {
                alert('An error has occured retrieving data!');
            }
        });
    }
    function ReceivedClientData(data) {
        var thegrid = $("#table");
        thegrid.clearGridData();
        for (var i = 0; i < data.length; i++)
            thegrid.addRowData(i + 1, data[i]);
    }
    function getMain(dObj) {
        if (dObj.hasOwnProperty('d'))
            return dObj.d;
        else
            return dObj;
    }
</script>

<h2>JQGrid</h2>
<table id="table" cellpadding="0" cellspacing="0"></table>
<div id="pager"></div>

