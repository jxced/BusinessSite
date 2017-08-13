    function categroy_operations(switch_on) {
        switch (switch_on) {
            case 'create':
                window.location.href = "/Admin/Dashboard/Category_Create";
                break;
            case 'del':
                break;
            case 'edit':
                break;
            default:
                alert("失败");
                break;
        }
    }
