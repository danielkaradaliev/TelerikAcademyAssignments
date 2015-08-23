//Problem 7. Parse URL
//
//Write a script that parses an URL address given in the format: [protocol]://[server]/[resource] and extracts from it the [protocol], [server] and [resource] elements.
//Return the elements in a JSON object.
//    Example:
//
//URL	                                                       result
//http://telerikacademy.com/Courses/Courses/Details/239	       protocol: http,
//                                                             server: telerikacademy.com
//                                                             resource: /Courses/Courses/Details/239

var url = "http://telerikacademy.com/Courses/Courses/Details/239",
    i,
    substr;
i = url.indexOf(':');
console.log("[protocol] = %s", url.substring(0, i));
substr = url.substr(0, i + 3);
url = url.replace(substr, '').trim();
i = url.indexOf('/');
console.log("[server] = %s", url.substring(0, i));
substr = url.substr(0, i);
url = url.replace(substr, '').trim();
console.log("[resource] = %s", url);