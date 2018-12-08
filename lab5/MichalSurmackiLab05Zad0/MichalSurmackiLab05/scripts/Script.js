// Rozpoczęcie pomiaru czasu
var trialStart = 0;
// ilosc prob
var howManyTrials = 5;
// tablica reakcji
var reactionTimes = [];
// czas konca reakcji
var trialEnd = 0;
// okreslenie numeru próby
var trialCounter = 0;
// zmienna losowa
var randomTimer = 0;

//resetowanie czasu
function ResetTimes() {
    for (var i = 0; i < howManyTrials; i++) {
        reactionTimes[i] = 0;
    }
}

// rozpoczecie odliczania do pomiau czasu
function StartIdle() {
    document.getElementById("button").src = "Images/buttonBlue.png";
    document.getElementById("button").onclick = function () {
        FalseStart();
    };
    if (trialCounter > howManyTrials - 1) {
        ResetTimes();
        trialCounter = 0;
        UpdateTable();
    }

    trialCounter++;
    randomTimer = Math.floor(Math.random() * 1000 + 500);
    setTimeout(StartTimer, randomTimer);
}

//Falstart
function FalseStart() {
    trialStart = new Date().getTime() - 1000;
    StopTimer();
}

//zatrzymanie pomiaru
function StopTimer() {
    document.getElementById("button").src = "Images/buttonRed.png";
    document.getElementById("button").onclick = function () { StartIdle(); };

    var average = 0;
    trialEnd = new Date().getTime() - trialStart;
    reactionTimes[trialCounter - 1] = trialEnd

    UpdateTable(average);

    if (trialCounter > howManyTrials - 1) {
        for (var i = 0; i < trialCounter; i++) {
            average += reactionTimes[i];
        }
        average = Math.round(average / howManyTrials);
        UpdateTable(average);
        alert("Your average reaction time: " + average + " ms");
    }
    
}

//aktualizacja tablicy
function UpdateTable(average) {
    document.getElementById("timesTable").innerHTML = "";
    document.getElementById("timesTable").innerHTML +=
        '<tr>' +
            '<th> Attempt No. </th>' +
            '<th> Reaction time </th>' +
        '</tr>';
    for (var i = 0; i < howManyTrials; i++) {
        document.getElementById("timesTable").innerHTML +=
            '<tr>' +
                '<td> Attempt ' + (i + 1) + '</td>' +
                '<td>' + reactionTimes[i] + ' ms' + '</td>' +
            '</tr>'

    }
    document.getElementById("timesTable").innerHTML +=
        '<tr>' +
        '<td> Average: </td>' +
        '<td>' + average + '</td>' +
        '</tr>';
}

// Rozpoczęcie czasu reakcji
function StartTimer() {
    document.getElementById("button").src = "Images/buttonGreen.png";
    document.getElementById("button").onclick = function () { StopTimer();};
    trialStart = new Date().getTime();
}