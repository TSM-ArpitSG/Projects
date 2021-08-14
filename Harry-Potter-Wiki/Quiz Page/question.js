function Quiz(questions) {
    this.score = 0;
    this.questions = questions;
    this.questionIndex = 0;
}
 
Quiz.prototype.getQuestionIndex = function() {
    return this.questions[this.questionIndex];
}
 
Quiz.prototype.guess = function(answer) {
    if(this.getQuestionIndex().isCorrectAnswer(answer)) {
        this.score++;
    }
 
    this.questionIndex++;
}
 
Quiz.prototype.isEnded = function() {
    return this.questionIndex === this.questions.length;
}
 
 
function Question(text, choices, answer) {
    this.text = text;
    this.choices = choices;
    this.answer = answer;
}
 
Question.prototype.isCorrectAnswer = function(choice) {
    return this.answer === choice;
}
 
 
function populate() {
    if(quiz.isEnded()) {
        showScores();
    }
    else {
        // show question
        var element = document.getElementById("question");
        element.innerHTML = quiz.getQuestionIndex().text;
 
        // show options
        var choices = quiz.getQuestionIndex().choices;
        for(var i = 0; i < choices.length; i++) {
            var element = document.getElementById("choice" + i);
            element.innerHTML = choices[i];
            guess("btn" + i, choices[i]);
        }
 
        showProgress();
    }
};
 
function guess(id, guess) {
    var button = document.getElementById(id);
    button.onclick = function() {
        quiz.guess(guess);
        populate();
    }
};
 
 
function showProgress() {
    var currentQuestionNumber = quiz.questionIndex + 1;
    var element = document.getElementById("progress");
    element.innerHTML = "Question " + currentQuestionNumber + " of " + quiz.questions.length;
};
 
function showScores() {
    var gameOverHTML = "<h3>Result</h3>";
    gameOverHTML += "<h3 id='score'> Your score: " + quiz.score + "</h3>";
    var element = document.getElementById("quiz");
    element.innerHTML = gameOverHTML;
};
 
// create questions here
var questions = [
    new Question("What spell did Harry use to kill Lord Voldemort?", ["Expelliarmus", "Expecto Patronum","Avada Kedavra", "Accio"], "Expelliarmus"),
    new Question("Albus Dumbledore destroyed which Horcrux?", ["Slytherin’s locket", "Nagini", "Hufflepuff’s cup", "Marvolo Gaunt’s ring"], "Marvolo Gaunt’s ring"),
    new Question("The tears of which animal are the only known antidote to basilisk venom?", ["Phoenix", "Billywig","Hippogriff", "Boggart"], "Phoenix"),
    new Question("What was the name of the Black family’s house elf?", ["Dobby", "Winky", "Kreacher", "Hokey"], "Kreacher"),
    new Question("What magical talent does Harry share with Voldemort?", ["Being an Animagus", "Being a Parselmouth", "Being an Auror", "Being a Death Eater"], "Being a parselmouth"),
    new Question("Which element is associated with Hufflepuff?", ["Fire", "Earth", "Air", "Water"], "Earth"),
    new Question("The ‘Felifors’ spell turns a cat into a what?", ["Hat", "Bat", "Matchbox", "Cauldron"], "Cauldron"),
    new Question("‘Wit beyond measure is man’s greatest treasure’ is the motto of which house?", ["Gryffindor", "Hufflepuff", "Ravenclaw", "Slytherin"], "Ravenclaw")
];
 
// create quiz
var quiz = new Quiz(questions);
 
// display quiz
populate();