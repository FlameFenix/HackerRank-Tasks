function TryCatch(s) {
    try {
        let word = s.split("").reverse().join("");
        console.log(word)
    } catch (ex) {
        console.log(ex.message);
        console.log(s)
    }
    
}

TryCatch(Number(1234));