let datatable;

$(document).ready(function () {
    loadDataTable();

});

function loadDataTable() {

    dataTable =  $('#tblDatos').dataTable({
        "ajax": {
            "url": "/Admin/Cliente/ObtenerTodos" 
        },
        "columns" : [
            {"data"}
        ]
    });
}