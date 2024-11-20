function adjustHrWidth() {
    input = document.getElementById('dynamicNameInput');
    hr = document.getElementById('dynamicNameHr');
    input.style.width = input.value.length + 1 + "ch";
    hr.style.width = input.value.length + 1 + "ch";
}

function calculateLastRowHeight() {
    row = document.getElementById('last-row');
    table = document.getElementById('game-list-table');
    console.log(table.parentElement.clientHeight);
    row.style.height = table.parentElement.clientHeight - table.clientHeight + "px";
}

window.clipboardCopy = {
    copyText: function (text) {
        navigator.clipboard.writeText(text).then(function () {
            //alert("Copied to clipboard!");
        })
        .catch(function (error) {
            //alert(error);
        });
    }
};

async function getFingerprint() {
    const fp = await FingerprintJS.load();
    const result = await fp.get();
    return result.visitorId;
}

function setCookie(name, value, days) {
    let expires = "";
    if (days) {
        const date = new Date();
        date.setTime(date.getTime() + days * 24 * 60 * 60 * 1000);
        expires = "; expires=" + date.toUTCString();
    }
    document.cookie = name + "=" + (value || "") + expires + "; path=/; Secure; SameSite=Strict";
}

function getCookie(name) {
    const nameEQ = name + "=";
    const ca = document.cookie.split(';');
    for (let i = 0; i < ca.length; i++) {
        let c = ca[i];
        while (c.charAt(0) === ' ') c = c.substring(1, c.length);
        if (c.indexOf(nameEQ) === 0) return c.substring(nameEQ.length, c.length);
    }
    return null;
}