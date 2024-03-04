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
    //valid that a 1 or 2 was entered for a number
    else if ((theNewNumber != 1) && (theNewNumber != 2))
    {
        alert("Please enter a 1 or 2 for the list.");
        document.forms["myForm"]["newNumber"].value = "";
        return false;
    }
    //a word and a 1 or 2 was entered so add the word to the proper table
    else
    {
        if (theNewNumber==1)
        {
            let tableRef = document.getElementById("myList1");
            (tableRef.insertRow(tableRef.rows.length)).innerHTML = theNewWord;            
        }
        else
        {
            let tableRef = document.getElementById("myList2");
            (tableRef.insertRow(tableRef.rows.length)).innerHTML = theNewWord;            
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
