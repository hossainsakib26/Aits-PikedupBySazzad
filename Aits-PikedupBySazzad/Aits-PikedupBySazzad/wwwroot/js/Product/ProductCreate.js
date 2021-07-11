

$(document.body).on("click", ".add-to-cart", function() {
    const id = $(this).attr("data-id");
    const name = $(`#${id}_Name`).text();
    const price = $(`#${id}_Price`).text();

    //const test = $(`#${id}_Name`).text(); // try

    const model = {};

    model.id = parseInt(id);
    model.name = name;
    model.price = parseFloat(price);
    model.qty = 1;

    const localData = localStorage.getItem(StoreKey.ADD_TO_CART_LIST);

    if (localData != null) {

    } else {
        const addToCartList = [];
        addToCartList.push(model);
        localStorage.setItem(StoreKey.ADD_TO_CART_LIST, addToCartList); // not working
    }

})