//funkcja odpowiadajaca za wpisanie danych do tabeli znajdujacej sie na glownej stronie 
function FillTheTable() {
    document.getElementById("musicAlbumsTable").innerHTML = "";
    document.getElementById("musicAlbumsTable").innerHTML +=
        '<tr>' +
            '<th> Rok wydania </th>' +
            '<th> Tytuł albumu </th>' +
            '<th> Artysta </th>' +
            '<th> Producent </th>' +
        '</tr>' +
        '<tr>' +
            '<th style="font-weight: normal"> 1996 </th>' +
            '<th onclick="OpenThePlaylist(\'KsiegaTajemniczaProlog\')" style="cursor: pointer; font-style: oblique; text-decoration: underline;"> <a href="../pages/playlist.html">Księga Tajemnicza Prolog</a> </th>' +
            '<th style="font-weight: normal"> Kaliber 44 </th>' +
            '<th style="font-weight: normal"> S.P. Records </th>' +
        '</tr>' +
        '<tr>' +
            '<th style="font-weight: normal"> 1959 </th>' +
            '<th onclick="OpenThePlaylist(\'KindOfBlue\')" style="cursor: pointer; font-style: oblique; text-decoration: underline;"> <a href="../pages/playlist.html">Kind Of Blue</a> </th>' +
            '<th style="font-weight: normal"> Miles Davis </th>' +
            '<th style="font-weight: normal"> Columbia Records </th>' +
        '</tr>' +
        '<tr>' +
            '<th style="font-weight: normal"> 2003 </th>' +
            '<th onclick="OpenThePlaylist(\'JazzWWolnychChwilach\')" style="cursor: pointer; font-style: oblique; text-decoration: underline;"> <a href="../pages/playlist.html">Jazz W Wolnych Chwilach</a> </th>' +
            '<th style="font-weight: normal"> O.S.T.R. </th>' +
            '<th style="font-weight: normal"> Asfalt Records </th>' +
        '</tr>' +
        '<tr>' +
            '<th style="font-weight: normal"> 2014 </th>' +
            '<th onclick="OpenThePlaylist(\'Kartagina\')" style="cursor: pointer; font-style: oblique; text-decoration: underline;"> <a href="../pages/playlist.html">Kartagina</a> </th>' +
            '<th style="font-weight: normal"> O.S.T.R. & Marco Polo </th>' +
            '<th style="font-weight: normal"> Asfalt Records </th>' +
        '</tr>' +
        '<tr>' +
            '<th style="font-weight: normal"> 1973 </th>' +
            '<th onclick="OpenThePlaylist(\'DarkSideOfTheMoon\')" style="cursor: pointer; font-style: oblique; text-decoration: underline;"> <a href="../pages/playlist.html">Dark Side Of The Moon</a> </th>' +
            '<th style="font-weight: normal"> Pink Floyd </th>' +
            '<th style="font-weight: normal"> Pink Floyd </th>' +
        '</tr>' + 
        '<tr>' +
            '<th style="font-weight: normal"> 1970 </th>' +
            '<th onclick="OpenThePlaylist(\'AtomHeartMother\')" style="cursor: pointer; font-style: oblique; text-decoration: underline;"> <a href="../pages/playlist.html">Atom Heart Mother</a> </th>' +
            '<th style="font-weight: normal"> Pink Floyd </th>' +
            '<th style="font-weight: normal"> Harvest Records, Capitol Records </th>' +
        '</tr>' + 
        '<tr>' +
            '<th style="font-weight: normal"> 2006 </th>' +
            '<th onclick="OpenThePlaylist(\'BlackHolesAndRevelations\')" style="cursor: pointer; font-style: oblique; text-decoration: underline;"> <a href="../pages/playlist.html">Black Holes And Revelations</a> </th>' +
            '<th style="font-weight: normal"> Muse </th>' +
            '<th style="font-weight: normal"> A&E Records </th>' +
        '</tr>' + 
        '<tr>' +
            '<th style="font-weight: normal"> 1979 </th>' +
            '<th onclick="OpenThePlaylist(\'TheWall\')" style="cursor: pointer; font-style: oblique; text-decoration: underline;"> <a href="../pages/playlist.html">The Wall</a> </th>' +
            '<th style="font-weight: normal"> Pink Floyd </th>' +
            '<th style="font-weight: normal"> Columbia Records </th>' +
        '</tr>';
}

//wywołanie funkcji z drugiego skryptu .js obsługującego plik playlist.html
function OpenThePlaylist(album) {
    alert('Wybrałeś ' + album);
    SetThePlaylist(album);
}