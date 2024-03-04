function validateANDadd() 
{
    //place the values in the form into variables
    let theNewWord = document.forms["myForm"]["newWord"].value;
    let theNewNumber = document.forms["myForm"]["newNumber"].value;

    //validate that something was entered as a word
    if (theNewWord == "")
    {
        //no word was entered to alert the user
        alert("Please enter a word to check");
        return false;
    }
    //valid that a 1 2 or 3 was entered for a number
    else if ((theNewNumber != 1) && (theNewNumber != 2) && (theNewNumber != 3))
    {
        alert("Please enter a 1, 2, or 3 for the algothim to use.");
        document.forms["myForm"]["newNumber"].value = "";
        return false;
    }
    //a word and a 1, 2, or 3 was entered so add the word to the proper table
    else
    {
        if (theNewNumber==1)
        {
            let tableRef = document.getElementById("myList1");
            (tableRef.insertRow(tableRef.rows.length)).innerHTML = theNewWord + ': ' + palindromeCheck1(theNewWord);            
        }
        else if (theNewNumber==2)
        {
            let tableRef = document.getElementById("myList2");
            (tableRef.insertRow(tableRef.rows.length)).innerHTML = theNewWord + ': ' + palindromeCheck2(theNewWord);  
        }
        else
        {
            let tableRef = document.getElementById("myList3");
            (tableRef.insertRow(tableRef.rows.length)).innerHTML = theNewWord + ': ' + palindromeCheck3(theNewWord);
        }
        //erase the form fields
        document.forms["myForm"]["newWord"].value = "";
        document.forms["myForm"]["newNumber"].value = "";
        return true;
    }
}

//clear all rows in tables
function clearList1()
{
    let tableRef = document.getElementById("myList1");
    tableRef.innerHTML = " ";    
}

function clearList2()
{
    let tableRef = document.getElementById("myList2");
    tableRef.innerHTML = " ";
}

function clearList3()
{
    let tableRef = document.getElementById("myList3");
    tableRef.innerHTML = " ";
}

//This checks for palindromes with built-in functions
function palindromeCheck1(word)
{
    //lowercase the string and use the RegExp to remove unwanted characters from it
    let re = /[^A-Za-z0-9]/g;
    let lowRegStr = word.toLowerCase().replace(re, '');
    let reverseStr = lowRegStr.split('').reverse().join(''); 
    //check if the two words match
    return reverseStr === lowRegStr;
}

//uses for loop and stores the reverse of the value
//compares the original and the reverse values
function palindromeCheck2(word) 
{
    let palindrome = false;
    let reverseStr = "";
    for (let i = word.length - 1; i >= 0; i--)
    {
        reverseStr += word[i];
    }
    if (reverseStr == word)
    {
        palindrome = true
        //return reverseStr === word
    }
    return palindrome
}

function palindromeCheck3(word) 
{
    //lowercase the string and use the RegExp to remove unwanted characters from it
    let palindrome = true;
    let re = /[^A-Za-z0-9]/g;
    word = word.toLowerCase().replace(re, '');
    
    //create the for loop, divides the length in half.
    //as long as characters from each part match, the loop will go on.
    let len = word.length;
    for (let i = 0; i < len/2; i++)
    {
        if (word[i] !== word[len - 1 - i])
        {
            palindrome = false;
        }
    }
    return palindrome;    
}