function validateANDadd() 
{
    //place the values in the form into variables
    let theNewTask = document.forms["myForm"]["newTask"].value;    

    //validate that something was entered
    if (theNewTask == "")
    {
        //no task was entered to alert the user
        alert("Please enter a task item.");
        return false;
    }
    
    //add the task to the table
    else
    {       
        let tableRef = document.getElementById("myTaskList");
        (tableRef.insertRow(tableRef.rows.length)).innerHTML = theNewTask;            
    }
    //erase the form fields
    document.forms["myForm"]["newTask"].value = "";        
    return true;
    
}

//clear all rows in tables
function clearList1()
{
    let tableRef = document.getElementById("myTaskList");
    tableRef.innerHTML = " ";    
}