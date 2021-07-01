    var DOM = $(document);
    DOM.ready(main);


    
function comprar(id) {
    var title = $('#nameTitleProduct' + id).html();
    localStorage.setItem('nameTitleProduct', title);
    alert("Solicita tu producto");
    window.location = 'contactenos';        
}

    


