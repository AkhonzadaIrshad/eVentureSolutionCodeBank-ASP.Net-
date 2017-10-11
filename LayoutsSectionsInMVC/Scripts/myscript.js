function isempty(id2chk, id4msg) {
    var elt2Chk = document.getElementById(id2chk);
    var elt4Msg = document.getElementById(id4msg);
    if (elt2Chk.value.length == 0) {
        elt4Msg.innerText = "empty";
    }
    else {
        elt4Msg.innerText = "";
    }
}

function welcome() {
    alert("welcome on page");
}