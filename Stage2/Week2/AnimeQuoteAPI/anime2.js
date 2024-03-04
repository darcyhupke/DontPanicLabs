async function getQuote()
{
    let apiString = "https://animechan.xyz/api/random";
    let theNewAnimeCharacter = document.getElementById("animeCharacter").value;
    let theNewAnime = document.getElementById("animeAnime").value;
    
    if (!(theNewAnimeCharacter == "default"))
        apiString = apiString + "/character?name=" + theNewAnimeCharacter;
    else
    if (!(theNewAnime == "default"))
        apiString = apiString + "/anime?title=" + theNewAnime;
    else
    {
        alert("Need to choose an Anime or a Character!");
        return true;
    }

    alert(apiString);

    let response = await fetch(apiString);

    document.getElementById("myAnimeQuote").innerHTML = "";

    let jsonData = await response.json();

    document.getElementById("myAnimeQuote").innerHTML = JSON.stringify(jsonData.quote);
    document.getElementById("myAnime").innerHTML = JSON.stringify(jsonData.anime);
    document.getElementById("myAnimeCharacter").innerHTML = JSON.stringify(jsonData.character);
    
    document.getElementById("animeCharacter").value="default";
    document.getElementById("animeAnime").value="default";

    return true;
}

