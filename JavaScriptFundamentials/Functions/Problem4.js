//Problem 4. Number of elements
//
//Write a function to count the number of div elements on the web page

function divCounter() {
    var divs = document.getElementsByTagName('div').length;
    console.log("Number of divs: %d",divs);
}

divCounter();

//Check browser's console!