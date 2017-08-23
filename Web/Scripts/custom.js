
//分类操作函数
function categroy_operations(operation) {
    switch (operation) {
            case 'create':
                window.location.href = "/Admin/Dashboard/Category_Create";
                break;
            case 'del':
                break;
            case 'edit':
                break;
            case 'select':
                break;
            default:
                alert("失败");
                break;
        }
}
//“新闻”操作函数
function news_operations(operation,id) {
    switch (operation) {
        case 'create':
            window.location.href = "/Admin/Dashboard/Category_Create/"+id;
            break;
        case 'del':
            break;
        case 'edit':
            break;
        case 'select':
            break;
        default:
            alert("失败");
            break;
    }
}
