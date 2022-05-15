let buttonFive = document.getElementById('btn5');

buttonFive.addEventListener('click', () => {
    let buttonOne = document.getElementById('btn1');
    let buttonTwo = document.getElementById('btn2');
    let buttonThree = document.getElementById('btn3');
    let buttonFour = document.getElementById('btn4');
    let buttonSix = document.getElementById('btn6');
    let buttonSeven = document.getElementById('btn7');
    let buttonEight = document.getElementById('btn8');
    let buttonNine = document.getElementById('btn9');
    
    let buttonOneValue = buttonOne.textContent;

    buttonOne.textContent = buttonFour.textContent;
    buttonFour.textContent = buttonSeven.textContent;
    buttonSeven.textContent = buttonEight.textContent;
    buttonEight.textContent = buttonNine.textContent;
    buttonNine.textContent = buttonSix.textContent;
    buttonSix.textContent = buttonThree.textContent;
    buttonThree.textContent = buttonTwo.textContent;
    buttonTwo.textContent = buttonOneValue;
})