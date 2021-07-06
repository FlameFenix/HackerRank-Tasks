function buttonClick() {
    let btnElement = document.getElementById('btn');
    let btnContent = Number(btnElement.textContent);
    btnContent++;
    btnElement.textContent = btnContent;

}
