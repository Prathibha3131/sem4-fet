// WHILE LOOP
let i = 1;
let whileText = "";

while (i <= 5) {
    whileText += "Number: " + i + "<br>";
    i++;
}

document.getElementById("whileLoop").innerHTML =
    "<b>While Loop Output:</b><br>" + whileText;


// DO...WHILE LOOP
let j = 1;
let doText = "";

do {
    doText += "Value: " + j + "<br>";
    j++;
} while (j <= 5);

document.getElementById("doWhileLoop").innerHTML =
    "<b>Do While Loop Output:</b><br>" + doText;
