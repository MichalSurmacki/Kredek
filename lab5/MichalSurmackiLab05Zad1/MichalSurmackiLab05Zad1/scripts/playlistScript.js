//Dodaje do pamięci podręcznej ścieżkę do pliku graficznego okładki albumu
function SetThePlaylist(album) {
    if (album == 'TheWall') {
        localStorage.setItem("variable", "../images/TheWall.jpg"); 
    }
    else if (album == 'KsiegaTajemniczaProlog') {
        localStorage.setItem("variable", "../images/KsięgaTajemniczaProlog.jpg");
    }
    else if (album == 'KindOfBlue') {
        localStorage.setItem("variable", "../images/KindOfBlue.jpg");
    }
    else if (album == 'JazzWWolnychChwilach') {
        localStorage.setItem("variable", "../images/JazzWWolnychChwilach.jpg");
    }
    else if (album == 'Kartagina') {
        localStorage.setItem("variable", "../images/Kartagina.jpg");
    }
    else if (album == 'DarkSideOfTheMoon') {
        localStorage.setItem("variable", "../images/DarkSideOfTheMoon.jpg");
    }
    else if (album == 'AtomHeartMother') {
        localStorage.setItem("variable", "../images/AtomHeartMother.jpg");
    }
    else if (album == 'BlackHolesAndRevelations') {
        localStorage.setItem("variable", "../images/BlackHolesAndRevelations.png");
    }
}

//wypełnia stronę danymi, obrazkiem i listą utworów
function FillTheSite() {
    var cover = localStorage.getItem("variable");
    document.getElementById('cover').src = cover;
    localStorage.removeItem("variable");
    if (cover == "../images/TheWall.jpg") {
        document.getElementById('playlist').innerHTML = "";
        document.getElementById('playlist').innerHTML += "<h1 style=\"text-align: center\">The Wall</h1>";
        document.getElementById('playlist').innerHTML +=
            "&nbsp; CD1." + "<br>" +
            "<ol>" +
                "<li>\"In the Flesh ?\" (Waters)</li>" +
                "<li>\"The Thin Ice\" (Waters)</li>" +
                "<li>\"Another Brick in the Wall, Part 1\" (Waters)</li>" +
                "<li>\"The Happiest Days of Our Lives\" (Waters)</li>" +
                "<li>\"Another Brick in the Wall, Part 2\" (Waters)</li>" +
                "<li>\"Mother\" (Waters)</li>" +
                "<li>\"Goodbye Blue Sky\" (Waters)</li>" +
                "<li>\"Empty Spaces\" (Waters)</li>" +
                "<li>\"Young Lust\" (Gilmour / Waters)</li>" +
                "<li>\"One of My Turns\" (Waters)</li>" +
                "<li>\"Don't Leave Me Now\" (Waters)</li>" +
                "<li>\"Another Brick in the Wall, Part 3\" (Waters)</li>" +
                "<li>\"Goodbye Cruel World\" (Waters)</li>" +
            "</ol>" +
            "&nbsp; CD2" + "<br>" +
            "<ol>" +
                "<li>\"Hey You\" (Waters)</li>" +
                "<li>\"Is There Anybody Out There ?\" (Waters)</li>" +
                "<li>\"Nobody Home\" (Waters)</li>" +
                "<li>\"Vera\" (Waters)</li>" +
                "<li>\"Bring the Boys Back Home\" (Waters)</li>" +
                "<li>\"Comfortably Numb\" (Gilmour / Waters)</li>" +
                "<li>\"The Show Must Go On\" (Waters)</li>" +
                "<li>\"In the Flesh\" (Waters)</li>" +
                "<li>\"Run Like Hell\" (Gilmour / Waters)</li>" +
                "<li>\"Waiting For The Worms\" (Waters)</li>" +
                "<li>\"Stop\" (Waters)</li>" +
                "<li>\"The Trial\" (Ezrin / Waters)</li>" +
                "<li>\"Outside the Wall\" (Waters)</li>" +
           "</ol>";
    }
    else if (cover == "../images/KsięgaTajemniczaProlog.jpg") {
        document.getElementById('playlist').innerHTML = "";
        document.getElementById('playlist').innerHTML += "<h1 style=\"text-align: center\">Księga Tajemnicza Prolog</h1>";
        document.getElementById('playlist').innerHTML +=
            "<ol>" +
                "<li>\"Wejście\"</li>" +
                "<li>\"Nasze mózgi wypełnione są marią\" (słowa: Mag Magik I, produkcja: Jajonasz, Mag Magik I)</li>" +
                "<li>\"Usłysz mój głos\" (słowa: Mag Magik I, produkcja: Mag Magik I)</li>" +
                "<li>\"Brat nie ma już miłości dla mnie\" (słowa: Lord MM Dab, produkcja: Mag Magik I, scratche: DJ Feel-X)</li>" +
                "<li>\"Psychoza\" (słowa: Mag Magik I, produkcja: Lord MM Dab, scratche: DJ Feel-X)</li>" +
                "<li>\"To czyni mnie innym od was wszystkich\" (słowa: Lord MM Dab, produkcja: Lord MM Dab, scratche: DJ Feel-X)</li>" +
                "<li>\"Więcej szmalu 2\" (słowa: Kaliber 44, produkcja: Mag Magik I, scratche: DJ Feel-X)</li>" +
                "<li>\"Do boju zakon marii\" (słowa: Lord MM Dab, Mag Magik I, produkcja: Jajonasz, Mag Magik I)</li>" +
                "<li>\"Bierz mój miecz i masz\" (słowa: Kaliber 44, produkcja: Jajonasz, Mag Magik I, scratche: DJ Feel-X)</li>" +
                "<li>\"Plus i minus\" (słowa: Mag Magik I, produkcja: Mag Magik I)</li>" +
                "<li>\"Moja obawa(bądź a klęknę)\" (słowa: Joka, produkcja: Rahim)</li>" +
                "<li>\"Psychodela\" (słowa: Jajonasz, Kaliber 44, gościnnie: 3-X - Klan, produkcja: Rahim)</li>" +
                "<li>\"Bez wyjścia\"</li>" +
            "</ol>";
    }
    else if (cover == "../images/KindOfBlue.jpg") {
        document.getElementById('playlist').innerHTML = "";
        document.getElementById('playlist').innerHTML += "<h1 style=\"text-align: center\">Kind Of Blue</h1>";
        document.getElementById('playlist').innerHTML +=
            "<ol>" +
                "<li>\"So What\"</li>" +
                "<li>\"Freddie Freeloader\"</li>" +
                "<li>\"Blue in Green\"</li>" +
                "<li>\"All Blues\"</li>" +
                "<li>\"Flamenco Sketches\"</li>" +
                "<li>\"Flamenco Sketches (alternatywna wersja)\"</li>" +
            "</ol>";
    }
    else if (cover == "../images/JazzWWolnychChwilach.jpg") {
        document.getElementById('playlist').innerHTML = "";
        document.getElementById('playlist').innerHTML += "<h1 style=\"text-align: center\">Jazz W Wolnych Chwilach</h1>";
        document.getElementById('playlist').innerHTML +=
            "&nbsp; CD1." + "<br>" +
            "<ol>" +
            "<li>\"Jazz nocnym rytmem\"</li>" +
            "<li>\"Początek...\"</li>" +
            "<li>\"Co ty tu robisz?\"(scratche: DJ Haem)</li>" +
            "<li>\"Boże igrzysko cz. 2\"(gitara: Marek Dulewicz)</li>" +
            "<li>\"Bałuty...\"(scratche: DJ Romek)</li>" +
            "<li>\"Problemy\"(scratche: DJ Kostek)</li>" +
            "<li>\"Nie lubię poniedziałków\"</li>" +
            "<li>\"Luzzzzz\"</li>" +
            "<li>\"Rap po godzinach\"(scratche: DJ Haem)</li>" +
            "<li>\"Życie\"(scratche: DJ Haem)</li>" +
            "<li>\"W oceanie zmysłów\"(scratche: DJ Haem)</li>" +
            "<li>\"Wszystko co mam\"(scratche: DJ Haem)</li>" +
            "<li>\"Korzenie\"(scratche: DJ Haem)</li>" +
            "<li>\"...\"</li>" +
            "<li>\"Program\"(scratche: DJ Kostek)</li>" +
            "<li>\"Z-Łodzi-eje\"(scratche: DJ Kostek)</li>" +
            "<li>\"Znam to\"(scratche: DJ Haem)</li>" +
            "<li>\"Człowiek z przyszłości\"</li>" +
            "<li>\"Jak być...?\"(scratche: DJ Kostek)</li>" +
            "<li>\"Jazz w wolnych chwilach (ziom odpocznij)\"(scratche: DJ Haem)</li>" +
            "</ol>" +
            "&nbsp; CD2." + "<br>" +
            "<ol>" +
            "<li>\"Huana\"(scratche: DJ Haem)</li>" +
            "<li>\"30 sekund\"(scratche: DJ Haem)</li>" +
            "<li>\"Wehikuł czasu\"(scratche: DJ Haem)</li>" +
            "<li>\"Dwie strony gry\"(scratche: DJ Haem)</li>" +
            "<li>\"Gangsterskie opowieści\"(scratche: DJ Kostek)</li>" +
            "<li>\"Słowo to siła\"(scratche: DJ Haem, DJ Kostek)</li>" +
            "<li>\"Patent na luxus\"(scratche: DJ Haem)</li>" +
            "<li>\"Luzzzzz\"</li>" +
            "<li>\"4 Elementy\"(scratche: DJ Funksion)</li>" +
            "<li>\"Hajabuza\"</li>" +
            "<li>\"Skazany na RAP\"(scratche: DJ Kostek, gitara: Marek Dulewicz)</li>" +
            "<li>\"Zamach stanu\"</li>" +
            "<li>\"Sztuka ulicy\"(scratche: DJ Haem)</li>" +
            "<li>\"Labirynt\"</li>" +
            "<li>\"Blok\"(scratche: DJ Kostek)</li>" +
            "<li>\"Mówisz...\"</li>" +
            "<li>\"Autobiografia\"(scratche: DJ Haem)</li>" +
            "<li>\"Nic pod publikę\"(scratche: DJ Kostek)</li>" +
            "<li>\"Cisza przed burzą\"</li>" +
            "<li>\"Kiedy mnie z tego zabierzesz\"(scratche: DJ Haem)</li>" +
            "<li>\"Samotność\"(skrzypce: O.S.T.R.)</li>" +
            "<li>\"Tabasko: Pokoje\"</li>" +
            "</ol>";
    }
    else if (cover == "../images/Kartagina.jpg") {
        document.getElementById('playlist').innerHTML = "";
        document.getElementById('playlist').innerHTML += "<h1 style=\"text-align: center\">Kartagina</h1>";
        document.getElementById('playlist').innerHTML +=
            "<ol>" +
                "<li>\"Intro\"(miksowanie: Chris Van Rootselaar, Jaap Wiewel)</li>" +
                "<li>\"Żywy lub martwy\"(miksowanie: Chris Van Rootselaar, Jaap Wiewel)</li>" +
                "<li>\"Side Effects\"(gościnnie: Cadillac Dale, miksowanie: Joe Nardone)</li>" +
                "<li>\"Kartagina\"(gościnnie: Lil' Fame, miksowanie: Joe Nardone)</li>" +
                "<li>\"Więzień własnych granic\"(miksowanie: Chris Van Rootselaar, Jaap Wiewel)</li>" +
                "<li>\"Hip Hop Hooligans\"(gościnnie: Hades, Main Flow, Torae)</li>" +
                "<li>\"Hołd bloków absolwentom\"(miksowanie: Chris Van Rootselaar, Jaap Wiewel)</li>" +
                "<li>\"Długi\"(miksowanie: Chris Van Rootselaar, Jaap Wiewel)</li>" +
                "<li>\"Nie słuchać przed trzydziestką\"(miksowanie: Chris Van Rootselaar, Jaap Wiewel)</li>" +
                "<li>\"Shotgun (Moje zło to twój wybór)\"(miksowanie: Chris Van Rootselaar, Jaap Wiewel)</li>" +
                "<li>\"Dead Man Funk\"(gościnnie: First Division, Kochan, miksowanie: Chris Van Rootselaar, Jaap Wiewel)</li>" +
                "<li>\"What Is The Question\"(miksowanie: Chris Van Rootselaar, Jaap Wiewel)</li>" +
                "<li>\"Garri Kasparow\"(gościnnie: Green, Kas, Zorak, miksowanie: Chris Van Rootselaar, Jaap Wiewel)</li>" +
                "<li>\"Miejmy to za sobą\"(miksowanie: Chris Van Rootselaar, Jaap Wiewel)</li>" +
                "<li>\"Przyjaciel diabła\"(miksowanie: Chris Van Rootselaar, Jaap Wiewel)</li>" +
                "<li>\"Ostatni Track\"(miksowanie: Chris Van Rootselaar, Jaap Wiewel)</li>" +
                "<li>\"Outro\"(miksowanie: Chris Van Rootselaar, Jaap Wiewel)</li>" +
            "</ol>";
    }
    else if (cover == "../images/DarkSideOfTheMoon.jpg") {
        document.getElementById('playlist').innerHTML = "";
        document.getElementById('playlist').innerHTML += "<h1 style=\"text-align: center\">Dark Side Of The Moon</h1>";
        document.getElementById('playlist').innerHTML +=
            "<ol>" +
                "<li>\"Speak to Me\" (Mason)</li>" +
                "<li>\"Breathe\" (Gilmour / Waters / Wright)</li>" +
                "<li>\"On the Run\" (Gilmour / Waters)</li>" +
                "<li>\"Time\" (Gilmour / Mason / Waters / Wright)</li>" +
                "<li>\"Breathe(Reprise)\" (Gilmour / Waters / Wright)</li>" +
                "<li>\"The Great Gig in the Sky\" (Wright)</li>" +
                "<li>\"Money\" (Waters)</li>" +
                "<li>\"Us and Them\" (Waters / Wright)</li>" +
                "<li>\"Any Colour You Like\" (Gilmour / Mason / Wright)</li>" +
                "<li>\"Brain Damage\" (Waters)</li>" +
                "<li>\"Eclipse\" (Waters)</li>" +
            "</ol>";
    }
    else if (cover == "../images/AtomHeartMother.jpg") {
        document.getElementById('playlist').innerHTML = "";
        document.getElementById('playlist').innerHTML += "<h1 style=\"text-align: center\">Atom Heart Mother</h1>";
        document.getElementById('playlist').innerHTML +=
            "<ol>" +
                "<li>\"Atom Heart Mother\" (Geesin/Gilmour/Mason/Waters/Wright)</li>" +
                "<li>\"If\" (Waters)</li>" +
                "<li>\"Summer '68\" (Wright)</li>" +
                "<li>\"Fat Old Sun\" (Gilmour)</li>" +
                "<li>\"Alan's Psychedelic Breakfast\" (Gilmour/Waters/Wright/Mason)</li>" +
            "</ol>";
    }
    else if (cover == "../images/BlackHolesAndRevelations.png") {
        document.getElementById('playlist').innerHTML = "";
        document.getElementById('playlist').innerHTML += "<h1 style=\"text-align: center\">Black Holes And Revelations</h1>";
        document.getElementById('playlist').innerHTML +=
            "<ol>" +
                "<li>\"Take a Bow\"</li>" +
                "<li>\"Starlight\"</li>" +
                "<li>\"Supermassive Black Hole\"</li>" +
                "<li>\"Map of the Problematique\"</li>" +
                "<li>\"Soldier's Poem\"</li>" +
                "<li>\"Invincible\"</li>" +
                "<li>\"Assassin\"</li>" +
                "<li>\"Exo-Politics\"</li>" +
                "<li>\"City of Delusion\"</li>" +
                "<li>\"Hoodoo\"</li>" +
                "<li>\"Knights of Cydonia\"</li>" +
                "<li>\"Glorious\"</li>" +
            "</ol>";
    }
}