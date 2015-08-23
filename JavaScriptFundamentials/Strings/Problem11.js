//Problem 11. String format
//
//Write a function that formats a string using placeholders.
//    The function should work with up to 30 placeholders and all types.
//    Examples:
//
//var str = stringFormat('Hello {0}!', 'Peter');
////str = 'Hello Peter!';
//
//var frmt = '{0}, {1}, {0} text {2}';
//var str = stringFormat(frmt, 1, 'Pesho', 'Gosho');
////str = '1, Pesho, 1 text Gosho'

function stringFormat() {
    var result = arguments[0],
        count,
        len,
        i;
    for (i = 0, len = arguments.length; i < len - 1; i += 1) {
        count = 0;
        while (result.indexOf('{' + i + '}', count) >= 0) {
            result = result.replace('{' + i + '}', arguments[i + 1]);
            count += 1;
        }
    }
    return result;
}

var str1 = stringFormat('Hello {0}!', 'Peter'),
    frmt = '{0}, {1}, {0} text {2}',
    str2 = stringFormat(frmt, 1, 'Pesho', 'Gosho');
console.log(str1);
console.log(str2);

