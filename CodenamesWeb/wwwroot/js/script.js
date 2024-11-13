function adjustHrWidth() {
    input = document.getElementById('dynamicNameInput');
    hr = document.getElementById('dynamicNameHr');
    input.style.width = input.value.length + 1 + "ch";
    hr.style.width = input.value.length + 1 + "ch";
}
