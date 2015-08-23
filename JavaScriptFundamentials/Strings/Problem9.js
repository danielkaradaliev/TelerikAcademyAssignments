//Problem 9. Extract e-mails
//
//Write a function for extracting all email addresses from given text.
//    All sub-strings that match the format @… should be recognized as emails.
//    Return the emails as array of strings.

function extractEmails (text){  //source: http://snipplr.com/view/26466/extract-email-from-bulk-text-with-regular-expressions-javascript--jquery/
    return text.match(/([a-zA-Z0-9._-]+@[a-zA-Z0-9._-]+\.[a-zA-Z0-9._-]+)/gi);
}
var input = "gdfgdsf@abv.bg jhlkj;k; fasfsda@gmail.com fasfas fsadfaasffsaf@ fsfs@yahoo.com",
    emails = extractEmails(input);

console.log(emails);