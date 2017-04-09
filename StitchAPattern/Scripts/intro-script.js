$('.item').each(function (i) {
    setTimeout(function(){
        $('.item').eq(i).addClass('is-visible');
    }, 200 * i);
});