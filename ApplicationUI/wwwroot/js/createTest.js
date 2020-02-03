
var CreateTestViewModel = {
    TestName: null,
    TestDescirption: null,
    BackgroundImage:null,
    Questions : []
};

 function ConvertToImage(fileSelector) {
    const file = document.querySelector(fileSelector).files[0];
    const reader = new FileReader();
     if (file) {
         reader.readAsDataURL(file);
     }
     reader.onloadend = () => {
         console.log(reader.result);
     }

}



function CreateTest() {

    CreateTestViewModel.TestName =document.getElementById("testName").value;
    CreateTestViewModel.TestDescription = document.getElementById("testDescription").value;

    console.log(CreateTestViewModel);
    fetch("/Test/CreateTestAsync", {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json'
        },
        dataType: "JSON",
        body: JSON.stringify(CreateTestViewModel)
    }).then(r => r.json())
        .then(r => console.log(r));
}


var addQuestionButton = document.querySelector(".addQuestion");
var questionsList = document.querySelector(".list_of_questions");
var questionText = document.querySelector(".questionTextInput");
var answerElements = document.querySelectorAll(".answerTextInput");
var radioElements = document.querySelectorAll('input[name="correctAnswer"');

addQuestionButton.onclick = () => {


    for (var i = 0; i < CreateTestViewModel.Questions.length; i++) {
        if (CreateTestViewModel.Questions[i].DisplayId == parseInt(questionText.dataset.id)) {
            
        }
    }

    var question = {
        DisplayId: document.querySelectorAll(".addedQuestion").length +1,
        QuestionText: questionText.value,
        BackgroundImage:  ConvertToImage("#questionBackground"),
      Answers : []
  };

    questionText.dataset.id = `${question.DisplayId}`


    for (var i = 0; i < answerElements.length; i++) {
        var Answer = {
         IsCorrect: radioElements[i].checked,
          AnswerText: answerElements[i].value
     }

      question.Answers.push(Answer);
    }
    console.log(questionText.dataset.id);
    CreateTestViewModel.Questions.push(question);
    AddQuestionToList(question);
    CleanInputs();
};


function CleanInputs() {
    for (var i = 0; i < answerElements.length; i++) {
        answerElements[i].value = null;
    }
    questionText.value = null;
}


function AddQuestionToList(question) {
    questionsList.innerHTML += `<div class="addedQuestion" onclick="GotoQuestion(${question.DisplayId})">
                <div class="questionIndex">
                    ${question.DisplayId}
                </div>
                <p>
                    ${question.QuestionText}
                </p>
            </div>`
}

function GotoQuestion(id) {
    for (var i = 0; i < CreateTestViewModel.Questions.length; i++) {

        if (CreateTestViewModel.Questions[i].DisplayId == id) {


            questionText.value = CreateTestViewModel.Questions[i].QuestionText;

            for (var k = 0; k < answerElements.length; k++) {
                answerElements[k].value = CreateTestViewModel.Questions[i].Answers[k].AnswerText;
                var d = 0;
            }
            CreateTestViewModel.Questions[i];
        }
    }
}