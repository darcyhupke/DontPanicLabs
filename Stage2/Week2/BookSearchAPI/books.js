async function getBooks()
{
    let apiString = "https://openlibrary.org/subjects/";
    let theNewCategory = document.getElementById("bookCategory").value;
       
    if (!(theNewCategory == "default"))        
        apiString = apiString + theNewCategory + ".json?details=true";
    else
    {
        alert("Please enter a book Category");
        return true;
    }

    alert(apiString);

    let response = await fetch(apiString);

    document.getElementById("myBookTitle").innerHTML = "";

    let jsonData = await response.json();
    

    document.getElementById("myBookTitle").innerHTML = JSON.stringify(jsonData.title);
    
    document.getElementById("bookCategory").value="default";
    
    return true;
}

