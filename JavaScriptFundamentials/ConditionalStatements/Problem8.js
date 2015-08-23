//Problem 8. Number as words
//
//Write a script that converts a number in the range [0…999] to words, corresponding to its English pronunciation.
//    Examples:
//
//numbers	number as words
//0	        Zero
//9	        Nine
//10	    Ten
//12	    Twelve
//19	    Nineteen
//25	    Twenty five
//98	    Ninety eight
//98	    Ninety eight
//273	    Two hundred and seventy three
//400	    Four hundred
//501	    Five hundred and one
//617	    Six hundred and seventeen
//711	    Seven hundred and eleven
//999	    Nine hundred and ninety nine

//Change input data here:
var number = 711;

var firstDigit;
var secondDigit;
var secondAndThirdDigits;
var thirdDigit;

var firstDigitAsText = "";
var secondDigitAsText = "";
var thirdDigitAsText = "";
var secondAndThirdDigitAsText = ""; //A little bit over descriptive maybe?

if (number >= 0 && number <= 9) {
    switch (number) {
        case 0: console.log("Zero"); break;
        case 1: console.log("One"); break;
        case 2: console.log("Two"); break;
        case 3: console.log("Three"); break;
        case 4: console.log("Four"); break;
        case 5: console.log("Five"); break;
        case 6: console.log("Six"); break;
        case 7: console.log("Seven"); break;
        case 8: console.log("Eight"); break;
        case 9: console.log("Nine"); break;
        default: break;
    }
}
else if (number >= 10 && number <= 19) {
    switch (number) {
        case 10: console.log("Ten"); break;
        case 11: console.log("Eleven"); break;
        case 12: console.log("Twelve"); break;
        case 13: console.log("Thirteen"); break;
        case 14: console.log("Fourteen"); break;
        case 15: console.log("Fifteen"); break;
        case 16: console.log("Sixteen"); break;
        case 17: console.log("Seventeen"); break;
        case 18: console.log("Eighteen"); break;
        case 19: console.log("Nineteen"); break;
        default: break;
    }
}
else if (number == 10 || number == 20 || number == 30 || number == 40 || number == 50 ||
    number == 60 || number == 70 || number == 80 || number == 90) {
    switch (number) {
        case 10: console.log("Ten"); break;
        case 20: console.log("Twenty"); break;
        case 30: console.log("Thirty"); break;
        case 40: console.log("Forty"); break;
        case 50: console.log("Fifty"); break;
        case 60: console.log("Sixty"); break;
        case 70: console.log("Seventy"); break;
        case 80: console.log("Eighty"); break;
        case 90: console.log("Ninety"); break;
        default: break;
    }
}
else if (number >= 21 && number <= 99) {
    firstDigit = (number / 10) | 0;
    secondDigit = (number % 10) | 0;
    firstDigitAsText = "";
    secondDigitAsText = "";
    switch (firstDigit) {
        case 2: firstDigitAsText = "Twenty"; break;
        case 3: firstDigitAsText = "Thirty"; break;
        case 4: firstDigitAsText = "Forty"; break;
        case 5: firstDigitAsText = "Fifty"; break;
        case 6: firstDigitAsText = "Sixty"; break;
        case 7: firstDigitAsText = "Seventy"; break;
        case 8: firstDigitAsText = "Eighty"; break;
        case 9: firstDigitAsText = "Ninety"; break;
        default: break;
    }
    switch (secondDigit) {
        case 1: secondDigitAsText = "one"; break;
        case 2: secondDigitAsText = "two"; break;
        case 3: secondDigitAsText = "three"; break;
        case 4: secondDigitAsText = "four"; break;
        case 5: secondDigitAsText = "five"; break;
        case 6: secondDigitAsText = "six"; break;
        case 7: secondDigitAsText = "seven"; break;
        case 8: secondDigitAsText = "eight"; break;
        case 9: secondDigitAsText = "nine"; break;
        default: break;
    }
    console.log(firstDigitAsText + " " + secondDigitAsText);
}
else if (number >= 100) {
    firstDigit = (number / 100) | 0;
    secondDigit = ((number / 10) % 10) | 0;
    thirdDigit = ((number % 100) % 10) | 0;
    secondAndThirdDigits = (number % 100) | 0;

    firstDigitAsText = "";
    secondDigitAsText = "";
    thirdDigitAsText = "";
    secondAndThirdDigitAsText = ""; //A little bit over descriptive maybe?

    switch (firstDigit) {
        case 1: firstDigitAsText = "One hundred"; break;
        case 2: firstDigitAsText = "Two hundred"; break;
        case 3: firstDigitAsText = "Three hundred"; break;
        case 4: firstDigitAsText = "Four hundred"; break;
        case 5: firstDigitAsText = "Five hundred"; break;
        case 6: firstDigitAsText = "Six hundred"; break;
        case 7: firstDigitAsText = "Seven hundred"; break;
        case 8: firstDigitAsText = "Eight hundred"; break;
        case 9: firstDigitAsText = "Nine hundred"; break;
        default: break;
    }

    //if (secondDigit == 0 && thirdDigit == 0) {
    //    console.log(firstDigitAsText);
    //}

    if (secondAndThirdDigits == 10 || secondAndThirdDigits == 11 || secondAndThirdDigits == 12 || secondAndThirdDigits == 13 || secondAndThirdDigits == 14
        || secondAndThirdDigits == 15 || secondAndThirdDigits == 16 || secondAndThirdDigits == 17 || secondAndThirdDigits == 18 || secondAndThirdDigits == 19
        || secondAndThirdDigits == 20 || secondAndThirdDigits == 30 || secondAndThirdDigits == 40 || secondAndThirdDigits == 50 || secondAndThirdDigits == 60
        || secondAndThirdDigits == 70 || secondAndThirdDigits == 80 || secondAndThirdDigits == 90) {
        switch (secondAndThirdDigits) {
            case 10: secondAndThirdDigitAsText = "and ten"; break;
            case 20: secondAndThirdDigitAsText = "and twenty"; break;
            case 30: secondAndThirdDigitAsText = "and thirty"; break;
            case 40: secondAndThirdDigitAsText = "and forty"; break;
            case 50: secondAndThirdDigitAsText = "and fifty"; break;
            case 60: secondAndThirdDigitAsText = "and sixty"; break;
            case 70: secondAndThirdDigitAsText = "and seventy"; break;
            case 80: secondAndThirdDigitAsText = "and eighty"; break;
            case 90: secondAndThirdDigitAsText = "and ninety"; break;
            case 11: secondAndThirdDigitAsText = "and eleven"; break;
            case 12: secondAndThirdDigitAsText = "and twelve"; break;
            case 13: secondAndThirdDigitAsText = "and thirteen"; break;
            case 14: secondAndThirdDigitAsText = "and fourteen"; break;
            case 15: secondAndThirdDigitAsText = "and fifteen"; break;
            case 16: secondAndThirdDigitAsText = "and sixteen"; break;
            case 17: secondAndThirdDigitAsText = "and seventeen"; break;
            case 18: secondAndThirdDigitAsText = "and eighteen"; break;
            case 19: secondAndThirdDigitAsText = "and nineteen"; break;
            default: break;
        }
        if (thirdDigit == 0 || secondAndThirdDigits == 10 || secondAndThirdDigits == 11 || secondAndThirdDigits == 12 || secondAndThirdDigits == 13 || secondAndThirdDigits == 14
            || secondAndThirdDigits == 15 || secondAndThirdDigits == 16 || secondAndThirdDigits == 17 || secondAndThirdDigits == 18 || secondAndThirdDigits == 19) {
            console.log(firstDigitAsText + " " + secondAndThirdDigitAsText);
        }
    }
    else {
        switch (secondDigit)
        {
            case 2: secondDigitAsText = "and twenty"; break;
            case 3: secondDigitAsText = "and thirty "; break;
            case 4: secondDigitAsText = "and forty"; break;
            case 5: secondDigitAsText = "and fifty"; break;
            case 6: secondDigitAsText = "and sixty"; break;
            case 7: secondDigitAsText = "and seventy"; break;
            case 8: secondDigitAsText = "and eighty"; break;
            case 9: secondDigitAsText = "and ninety"; break;
            default: break;
        }
        if (secondDigit == 0 && thirdDigit != 0) {
            secondDigitAsText += " and";
        }
        switch (thirdDigit) {
            case 1: thirdDigitAsText = "one"; break;
            case 2: thirdDigitAsText = "two"; break;
            case 3: thirdDigitAsText = "three"; break;
            case 4: thirdDigitAsText = "four"; break;
            case 5: thirdDigitAsText = "five"; break;
            case 6: thirdDigitAsText = "six"; break;
            case 7: thirdDigitAsText = "seven"; break;
            case 8: thirdDigitAsText = "eight"; break;
            case 9: thirdDigitAsText = "nine"; break;
            default: break;
        }
        console.log(firstDigitAsText + " " + secondDigitAsText + " " + thirdDigitAsText);
    }
}
//console.log(firstDigitAsText);
//console.log(secondAndThirdDigitAsText);
//console.log(thirdDigitAsText);
//console.log();
//console.log(firstDigit);
//console.log(secondDigit);
//console.log(thirdDigit);