//Problem 12. Generate list
//
//Write a function that creates a HTML <ul> using a template for every HTML <li>.
//The source of the list should be an array of elements.
//    Replace all placeholders marked with –{…}– with the value of the corresponding property of the object.
//    Example: HTML:
//
//    <div data-type="template" id="list-item">
//    <strong>-{name}-</strong> <span>-{age}-</span>
///div>
//JavaScript:
//
//var people = [{name: 'Peter', age: 14},…];
//var tmpl = document.getElementById('list-item').innerHtml;
//var peopleList = generateList(people, template);
////peopleList = '<ul><li><strong>Peter</strong> <span>14</span></li><li>…</li>…</ul>'

function generateList(people, template) {
    var output = '<ul>',
        i,
        len = people.length;
    for (i = 0; i < len; i += 1) {
        output += '<li>';
        output += template.replace('-{name}-', people[i]['name'])
            .replace('-{age}-', people[i]['age']);
        output += '</li>';
    }
    return output + '</ul>';
}

var people = [
    {name: 'Peter', age: 14},
    {name: 'Gosho', age: 18},
    {name: 'Jana', age: 20},
    {name: 'Ivan', age: 25}
    ],
    template = '<strong>-{name}-</strong> <span>-{age}-</span>';

console.log(generateList(people, template));