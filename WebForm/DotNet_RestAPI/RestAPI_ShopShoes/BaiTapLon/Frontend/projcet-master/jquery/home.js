function login() {
    $.ajax({
        url: 'https://localhost:44315//api/khachhang/' + $("#full-name").val(),
        method: 'GET',
        contentType: 'application\json',
        dataType: 'json',
        error: function(response) {
            alert('Lỗi đăng nhập');
        },
        success: function(reponse) {
            if (reponse.MatKhau == $("#password").val()) {
                document.getElementById('log').innerText = reponse.HoTen;
                GetMiniCart();
                alert('Đăng nhập thành công');
                form_element.classList.remove('active');
                localStorage.setItem("user", JSON.stringify(reponse))
            } else {
                alert('Mật khẩu không chính xác')
            }
        },
        fail: function(response) {
            alert('Không tồn tại tài khoản');
        }
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
                    <a href="./element/product1.html?id=${reponse[i].id}"><img src="./images/${reponse[i].Anh}" alt=""></a>
                                    <span class="text-large">${reponse[i].TenSanPham}
                                                        <span class="text-small">${tien.toString().replace(/(\d)(?=(\d{3})+(?!\d))/g, "$1,")}₫</span>
                                                        <span class="rules"></span>
                                                        <span class="remove">&times;</span>
                                                    </div>`
            }
            document.getElementById('minicart').innerHTML = table;
            document.getElementById('carticon').innerText = reponse.length;
            localStorage.setItem("cartitem", JSON.stringify(reponse))
        },
        fail: function(response) {}
    });
}
$(document).ready(function() {
    GetSale();
    GetNews();
    const login = JSON.parse(localStorage.getItem('user'))
    if (login) {
        document.getElementById('log').innerText = login.HoTen;
    } else {
        document.getElementById('log').innerText = 'Đăng nhập/Đăng ký'
    }
    const cartitem = JSON.parse(localStorage.getItem('cartitem'))
    if (cartitem) {
        let table = '';

        for (var i = 0; i < cartitem.length; ++i) {
            tien = (100 - cartitem[i].Sale) / 100 * cartitem[i].Gia;
            table = table + `
                <div class="mini-cart">
                    <a href="./element/product1.html?id=${reponse[i].id}" ><img  src="./images/${cartitem[i].Anh}" alt=""></a>
                                    <span class="text-large">${cartitem[i].TenSanPham}
                                                        <span class="text-small">${tien.toString().replace(/(\d)(?=(\d{3})+(?!\d))/g, "$1,")}₫</span>
                                                        <span class="rules"></span>
                                                        <span class="remove">&times;</span>
                                                    </div>`
        }
        document.getElementById('minicart').innerHTML = table;
        document.getElementById('carticon').innerText = cartitem.length;
    }
});

//Hàm lấy ra những sản phẩm sale nhiều nhất
function GetSale() {
    $.ajax({
        url: 'https://localhost:44315//api/product/',
        method: 'GET',
        contentType: 'application\json',
        dataType: 'json',
        error: function(response) {},
        success: function(reponse) {
            const len = 8;

            let table = '';
            for (var i = 0; i < len; ++i) {
                tien = (100 - reponse[i].Sale) / 100 * reponse[i].Gia;
                table = table + `
    <div class="col l-3 m-3 xm-6 sm-6  c-12">
        <div class="onSale">
            <span class="sale">-${reponse[i].Sale}%</span>
        </div>
        <a href="./element/product1.html?id=${reponse[i].id}"><img src="./images/${reponse[i].Anh}" alt="image"></a>
        <div class="text-box">
            <div class="title-wrapper">${reponse[i].TenSanPham}</div>
            <div class="price-wrapper"><span class="sale-off">${reponse[i].Gia}</span> ${tien.toString().replace(/(\d)(?=(\d{3})+(?!\d))/g, "$1,")}₫
            </div>
        </div>
    </div>`
            }
            document.getElementById('allKH').innerHTML = table;
        },
        fail: function(response) {}
    });
}

function GetNews() {
    $.ajax({
        url: 'https://localhost:44315//api/product',
        method: 'POST',
        contentType: 'application\json',
        dataType: 'json',
        error: function(response) {},
        success: function(reponse) {
            const len = 9;

            let tabl = '';
            for (var i = 0; i < len; ++i) {
                tien = (100 - reponse[i].Sale) / 100 * reponse[i].Gia;
                tabl = tabl + `
                <div class="col l-4 m-4 xm-4 c-12 product">
                    <div class="onSale">
                        <span class="sale">-${reponse[i].Sale}%</span>
                    </div>
                    <a href="./element/product1.html?id=${reponse[i].id}"><img src="./images/${reponse[i].Anh}" alt="image"></a>
                    <div class="text-box">
                        <div class="title-wrapper">${reponse[i].TenSanPham}</div>
                        <div class="price-wrapper">
                            <span class="sale-off">${reponse[i].Gia}₫ </span> ${tien.toString().replace(/(\d)(?=(\d{3})+(?!\d))/g, "$1,")}₫
                        </div>
                    </div>
                </div>`
            }
            document.getElementById('spnew').innerHTML = tabl;
        },
        fail: function(response) {}
    });
}

function logout() {
    localStorage.setItem("user", null);
    localStorage.setItem("cartitem", null)
}