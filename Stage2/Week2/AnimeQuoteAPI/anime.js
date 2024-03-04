async function getCharacterQuote()
{
    let apiString = "https://animechan.xyz/api/random";
    let theNewAnimeCharacter = document.getElementById("animeCharacter").value;
       
    apiString = apiString + "/character?name=" + theNewAnimeCharacter;

    alert(apiString);

    let response = await fetch(apiString);

    document.getElementById("myAnimeQuote").innerHTML = "";

    let jsonData = await response.json();

    //let theNewQuote = JSON.stringify(jsonData)

    document.getElementById("myAnimeQuote").innerHTML = JSON.stringify(jsonData.quote);
    document.getElementById("myAnime").innerHTML = JSON.stringify(jsonData.anime);
    document.getElementById("myAnimeCharacter").innerHTML = JSON.stringify(jsonData.character);
    
    return true;
}

async function getAnimeQuote()
{
    let apiString = "https://animechan.xyz/api/random";
    let theNewAnime = document.getElementById("animeAnime").value;
       
    apiString = apiString + "/anime?title=" + theNewAnime;

    alert(apiString);

    let response = await fetch(apiString);

    document.getElementById("myAnimeQuote").innerHTML = "";

    let jsonData = await response.json();

    //let theNewQuote = JSON.stringify(jsonData)

    document.getElementById("myAnimeQuote").innerHTML = JSON.stringify(jsonData.quote);
    document.getElementById("myAnime").innerHTML = JSON.stringify(jsonData.anime);
    document.getElementById("myAnimeCharacter").innerHTML = JSON.stringify(jsonData.character);
    
    return true;
}