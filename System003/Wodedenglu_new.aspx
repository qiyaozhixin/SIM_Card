<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Wodedenglu_new.aspx.cs" Inherits="System003.Wodedenglu_new" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <meta charset="utf-8"/>
    <meta http-equiv="X-UA-Compatible" content="IE=edge"/>
    <meta name="viewport" content="width=device-width, initial-scale=1"/>
    <title>中国联通电话卡销售管理系统</title>
    <link href="../bootstrap/css/bootstrap.min.css" rel="stylesheet"/>
    <link rel="stylesheet" href="../bootstrap/dist_select/css/bootstrap-select.css"/>
    <script src="../jquery/1.11.1/jquery.min.js"></script>
    <script src="../bootstrap/dist_select/js/bootstrap-select.js"></script>
      <style>
        body { padding-top: 100px; }
      </style>
</head>
<body style="background-image: url('Image/background_login.jpg')">
    <div class="container">
        <div class="center-block" style="width:400px;">
            <header class="l-center">
                <h3 class="showcase-title">登录账户</h3>
            </header>
        </div>
        <div class="center-block" style="width:400px;">
            <div class="well well-lg">
                <label for="name">类别</label>
                <div class="form-group">
                    <select id="choosedepartment" class="selectpicker" title="请选择部门">
                        <option>普通员工</option>
                        <option>部门经理</option>
                        <option>地推网点经理</option>
                        <option>总经理</option>
                    </select>
                </div>
                <div class="form-group">
		             <label for="OA">OA</label> 
                     <input type="text" class="form-control" id="name" placeholder="请输入OA" />
	            </div>
                <div class="form-group">
		             <label for="password">密码</label>
		             <input type="password" class="form-control" id="password" placeholder="请输入密码" />
	            </div>
                <button type="submit" class="btn btn-default">登录</button>
            </div>
        </div>
    </div>
    <script src="../bootstrap/js/bootstrap.min.js"></script>
    <script>
  $(document).ready(function () {
    var mySelect = $('#first-disabled2');

    $('#special').on('click', function () {
      mySelect.find('option:selected').prop('disabled', true);
      mySelect.selectpicker('refresh');
    });

    $('#special2').on('click', function () {
      mySelect.find('option:disabled').prop('disabled', false);
      mySelect.selectpicker('refresh');
    });

    $('#basic2').selectpicker({
      liveSearch: true,
      maxOptions: 1
    });
  });
</script>
</body>
</html>
