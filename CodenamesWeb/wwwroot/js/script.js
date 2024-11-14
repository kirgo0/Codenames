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