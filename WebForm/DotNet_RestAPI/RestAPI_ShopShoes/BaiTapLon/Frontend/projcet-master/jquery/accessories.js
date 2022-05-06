$(document).ready(function() {
    GiayNike();
    const login = JSON.parse(localStorage.getItem('login'))
    console.log(login.HoTen)
    if (login) {
        document.getElementById('username').innerText = login.HoTen;
    } else {
        document.getElementById('username').innerText = 'Đăng nhập/Đăng ký'
    }
});
//Hàm lấy ra giày nike
function GiayNike() {
    $.ajax({
        url: 'https://localhost:44315/api/product/3',
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
                <div class="col l-4 m-4 xm-6 sm-6">
                            <div class="onSale">
                                <span class="sale">-${reponse[i].Sale}%</span>
                            </div>
                            <a href="./product1.html?id=${reponse[i].id}"><img src="../images/${reponse[i].Anh}"
                                    alt="image"></a>
                            <div class="text-box">
                                <div class="title-wrapper">${reponse[i].TenSanPham}</div>
                                <div class="price-wrapper"><span class="sale-off">${reponse[i].Gia}đ</span>
                                    ${tien.toString().replace(/(\d)(?=(\d{3})+(?!\d))/g, "$1,")}₫</div>
                            </div>
                        </div>`
            }
            document.getElementById('phukien').innerHTML = table;
        },
        fail: function(response) {}
    });
}