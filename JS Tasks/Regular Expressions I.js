
function regexVar(input) {
    /*
     * Declare a RegExp object variable named 're'
     * It must match a string that starts and ends with the same vowel (i.e., {a, e, i, o, u})
     */
    let re = /((^[aeiou]{1})([a-z]{1,})(\2))$/;
    return re;
}