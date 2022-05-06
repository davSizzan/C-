$(document).ready(function() {
    GetCart();
    GetMiniCart();
});

function GetCart() {
    $.ajax({
        url: 'https://localhost:44315//api/giohang/',
        method: 'GET',
        contentType: 'application\json',
        dataType: 'json',
        error: function(response) {},
        success: function(reponse) {
            const len = reponse.length;
            tongtien = 0;
            let table = '';
            for (var i = 0; i < len; ++i) {
                tien = (100 - reponse[i].Sale) / 100 * reponse[i].Gia;
                tongtien = tongtien + tien;
                table = table + `
            <div class="cart-form">
                    <div class="remove">
                        <div onclick ="deletesp(${reponse[i].id})">&times;</div>
                    </div>
                    <div class="thumbnail"><img src="../images/${reponse[i].Anh}" alt=""></div>
                    <div class="name">${reponse[i].TenSanPham}</div>
                    <div class="price">${reponse[i].Gia}₫</div>
                    <div class="quanity">
                        <div>
                            <input type="button" value="-" class="minus">
                            <div class="number">1</div>
                            <input type="button" value="+" class="plus">
                        </div>
                    </div>
                    <div class="total">${tien.toString().replace(/(\d)(?=(\d{3})+(?!\d))/g, "$1,")}₫</div>
                </div>`
            }
            document.getElementById('cart').innerHTML = table;
            document.getElementById('tongtien').innerText = tongtien.toString().replace(/(\d)(?=(\d{3})+(?!\d))/g, "$1,") + 'đ';
            document.getElementById('tamtinh').innerText = tongtien.toString().replace(/(\d)(?=(\d{3})+(?!\d))/g, "$1,") + 'đ';
        },
        fail: function(response) {}
    });
}

function deletesp(id) {
    $.ajax({
        url: 'https://localhost:44315//api/giohang?id=' + id,
        method: 'DELETE',
        contentType: 'application\json',
        dataType: 'json',
        error: function(response) {},
        success: function(reponse) {
            GetCart();
        },
        fail: function(response) {}
    });
}

function GetMiniCart() {
    $.ajax({
        url: 'https://localhost:44315//api/giohang/',
        method: 'GET',
        contentType: 'application\json',
        dataType: 'json',
        error: function(response) {},
        success: function(reponse) {
            const len = reponse.length;
            let table = '';
            for (var i = 0; i < len; ++i) {
                tien = (100 - reponse[i].Sale) / 100 * reponse[i].Gia;

                table = table + `
            <div class="mini-cart">
                <a href="./product1.html"><img src="../images/${reponse[i].Anh}" alt=""></a>
                                <span class="text-large">${reponse[i].TenSanPham}
                                                    <span class="text-small">${tien.toString().replace(/(\d)(?=(\d{3})+(?!\d))/g, "$1,")}₫</span>
                                                    <span class="rules"></span>
                                                    <span class="remove">&times;</span>
                                                </div>`
            }
            document.getElementById('minicart').innerHTML = table;
            document.getElementById('carticon').innerText = len;

        },
        fail: function(response) {}
    });
}

function thanhtoan() {
    alert('Thanh toán thành công');
    localStorage.setItem("cartitem", null)
    $.ajax({
        url: 'https://localhost:44315//api/giohang',
        method: 'DELETE',
        contentType: 'application\json',
        dataType: 'json',
        error: function(response) {},
        success: function(reponse) {
            GetCart();
        },
        fail: function(response) {}
    });
}