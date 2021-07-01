$(document).ready(function () {

    if (localStorage.getItem('nameTitleProduct') != undefined) {
        $('#opinion').html(localStorage.getItem('nameTitleProduct'));
                
    }
    localStorage.removeItem('nameTitleProduct');

    
    
});