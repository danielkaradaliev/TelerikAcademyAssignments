//Problem 6. Extract text from HTML
//
//Write a function that extracts the content of a html page given as text.
//    The function should return anything that is in a tag, without the tags.
//    Example:
//
//<html>
//<head>
//<title>Sample site</title>
//</head>
//<body>
//<div>text
//<div>more text</div>
//and more...
//</div>
//in body
//</body>
//</html>
//Result: Sample sitetextmore textand more...in body
var input = "<html> <head> <title>Sample site</title> </head> <body> <div>text <div>more text</div>and more... </div>in body </body> </html>",
    output;

function replaceTags(str){
    var openingBracket = str.indexOf("<"),
        closingBracket = str.indexOf(">"),
        currentTag;

    while (openingBracket > -1) {
        currentTag = str.substring(openingBracket, closingBracket + 1);
        str = str.replace(currentTag, "");
        openingBracket = str.indexOf("<");
        closingBracket = str.indexOf(">");
    }

    return str;
}

output = replaceTags(input);

console.log(output);