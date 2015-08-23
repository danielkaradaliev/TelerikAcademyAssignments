//Problem 2. HTML binding
//
//Write a function that puts the value of an object into the content/attributes of HTML tags.
//    Add the function to the String.prototype
//
//Example 1:
//
//input
//
//var str = '<div data-bind-content="name"></div>';
//str.bind(str, {name: 'Steven'});
//output
//
//<div data-bind-content="name">Steven</div>
//
//    Example 2:
//
//input
//
//var bindingString = '<a data-bind-content="name" data-bind-href="link" data-bind-class="name"></?>'
//str.bind(str, {name: 'Elena', link: 'http://telerikacademy.com'});
//output
//
//<a data-bind-content="name" data-bind-href="link" data-bind-class="name" href="http://telerikacademy.com" class="Elena">Elena</?>

if (!String.prototype.bind) {
    String.prototype.bind = function (str, obj) {
        var pattern = /<[A-z0-9"\s\-=\/]+>/g,
            patternName = /data-bind-content="name"/,
            patternLink = /data-bind-href="link"/,
            patternClass = /data-bind-class="name"/,
            result;
        if (patternName.test(this)) {
            result = this.match(pattern)
                .join(obj.name);
        }
        if (patternLink.test(this)) {
            result = result.replace('>', ' href=' + '"' + obj.link + '">');
        }
        if (patternClass.test(this)) {
            result = result.replace('>', ' class=' + '"' + obj.name + '">');
        }
        return result;
    }
}

var str1 = '<div data-bind-content="name"></div>',
    str2 = '<a data-bind-content="name" data-bind-href="link" data-bind-class="name"></?>';

console.log(str1.bind(str1, {name: 'Steven'}));
console.log(str2.bind(str2, {name: 'Elena', link: 'http://telerikacademy.com'}));