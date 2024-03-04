async function getBaconIpsum()
{
    let apiString = "https://baconipsum.com/api/";
    let theNewParagraphs = document.getElementById("paragraphs").value;
    
    apiString = apiString + "?type=all-meat&paras=" + theNewParagraphs;
    alert(apiString);

    let response = await fetch(apiString);

    document.getElementById("myRawData").innerHTML = "";
    document.getElementById("myFormatData").innerHTML = "";

    let jsonData = await response.json();

    document.getElementById("myRawData").innerHTML = JSON.stringify(jsonData);

    for (let para in jsonData)
    {
        document.getElementById("myFormatData").innerHTML += "<p>" + jsonData[para] + "</p>";
    }

    return true;

}