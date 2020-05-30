function solonumeros(e) {

    var key;

    if (window.event)
    {
        key = e.keyCode;
    }
    else if (e.which)
    {
        key = e.which;
    }

    if (key < 48 || key > 57) {
        return false;
    }

    return true;
}