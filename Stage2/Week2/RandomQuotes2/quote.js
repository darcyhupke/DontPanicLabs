async function getRandomQuote()
{
    let apiString = "https://api.quotable.io/random";
    let theNewQuoteLength = document.getElementById("quoteLength").value;

    let minQuoteLength = 0;
    let maxQuoteLength = 1000;

    if (theNewQuoteLength == 1)
        maxQuoteLength = 50;
    else 
        if (theNewQuoteLength == 2)
        {
            minQuoteLength = 50;
            maxQuoteLength = 300;
        }
        else
            minQuoteLength = 300;
    
    apiString = apiString + "?minLength=" + minQuoteLength + "&maxLength=" + maxQuoteLength;

    alert(apiString);

    let response = await fetch(apiString);

    document.getElementById("myRandomQuote").innerHTML = "";
    document.getElementById("myRandomAuthor").innerHTML = "";

    let jsonData = await response.json();

    let theNewQuote = JSON.stringify(jsonData.content);
    theNewQuote = theNewQuote.substring(1,theNewQuote.length-1);
    document.getElementById("myRandomQuote").innerHTML = theNewQuote;
    let theNewAuthor = JSON.stringify(jsonData.author);
    theNewAuthor = theNewAuthor.substring(1,theNewAuthor.length-1);
    document.getElementById("myRandomAuthor").innerHTML = theNewAuthor;

    return true;
}