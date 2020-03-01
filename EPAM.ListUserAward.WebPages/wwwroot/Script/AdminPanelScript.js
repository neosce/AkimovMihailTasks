$('#btn_logOut').click(function ()
{
    location.href = "/Pages/SignOut";
})

$('#myModal').modal('show');
$('#myModalEmail').modal('show');
$('#myModalAddUser').modal('show');
$('#myModalAddAward').modal('show');
$('#myModalDeleteAward').modal('show');
$('#myModalLogoUserLoad').modal('show');

$('.toast').toast(
    {
        animation: true,
        autohide: true,
        delay: 5000
    })
$('.toast').toast('show');