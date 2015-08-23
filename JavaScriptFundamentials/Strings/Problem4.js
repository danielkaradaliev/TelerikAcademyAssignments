//Problem 4. Parse tags
//
//You are given a text. Write a function that changes the text in all regions:
//
//    <upcase>text</upcase> to uppercase.
//<lowcase>text</lowcase> to lowercase
//<mixcase>text</mixcase> to mix casing(random)
//Example: We are <mixcase>living</mixcase> in a <upcase>yellow submarine</upcase>. We <mixcase>don't</mixcase> have <lowcase>anything</lowcase> else.
//
//The expected result:
//    We are LiVinG in a YELLOW SUBMARINE. We dOn'T have anything else.
//
//Note: Regions can be nested.

function parseTags(input) {
    var i,
        jump,
        random,
        currentStateArr = [],
        output = [],
        textLen = input.length,
        currentStateArrLen;

    for (i = 0; i < textLen; i += 1) {
        if (input[i] === '<') {
            switch (input[i + 1]) {
                case 'u':
                    currentStateArr.push('u');
                    jump = input.indexOf('>', i);
                    i = jump + 1;
                    break;
                case 'l':
                    currentStateArr.push('l');
                    jump = input.indexOf('>', i);
                    i = jump + 1;
                    break;
                case 'm':
                    currentStateArr.push('m');
                    jump = input.indexOf('>', i);
                    i = jump + 1;
                    break;
                case '/':
                    currentStateArr.pop();
                    jump = input.indexOf('>', i);
                    i = jump + 1;
                    break;
            }
        }
        currentStateArrLen = currentStateArr.length;
        switch (currentStateArr[currentStateArrLen - 1]) {
            case undefined:
                output.push(input[i]);
                break;
            case 'u':
                output.push(input[i].toUpperCase());
                break;
            case 'l':
                output.push(input[i].toLowerCase());
                break;
            case 'm':
                random = Math.random();
                if (random < 0.5) {
                    output.push(input[i].toLowerCase());
                    break;
                } else {
                    output.push(input[i].toUpperCase());
                    break;
                }
        }
    }
    return output.join('');
}

var inputString = "We are <mixcase>living</mixcase> in a <upcase>yellow submarine</upcase>. We <mixcase>don't</mixcase> have <lowcase>anything</lowcase> else.";
var output = parseTags(inputString);
console.log(output);