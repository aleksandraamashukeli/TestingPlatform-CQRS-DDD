
const selectAnswer = () => {
    var answersContainer = event.path[1].children;


    for (var i = 0; i < answersContainer.length; i++) {
        answersContainer[i].classList.remove("selected")
    }
    event.target.classList.add("selected");

    getSelectedAnswers();
}

const submit = () => {
    var json = getSelectedAnswers();
    fetch("/Test/SubmitTest", {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json'
        },
        dataType: "JSON",
        body: JSON.stringify(json)
    })
        .then(r => r.text())
        .then(r => alert(`რეზულტატი: ${r} ქულა`))
}



const getSelectedAnswers = () => {
    let _testId = document.querySelector(".testpageContainer").dataset.id;

    let jsonData = {
        testId: parseInt(_testId),
        finishedQuestions: [

        ]
    }

    let questions = document.querySelectorAll(".questionContainer");

    for (var i = 0; i < questions.length; i++) {

        let finishedQuestion = {
            answerId: null,
            questionId: null
        };

        finishedQuestion.questionId = parseInt(questions[i].dataset.id);


        let answers = questions[i].children[1].children;


        for (var j = 0; j < answers.length; j++) {

            if (answers[j].classList.contains("selected")) finishedQuestion.answerId = parseInt(answers[j].dataset.id)
        }


        jsonData.finishedQuestions.push(finishedQuestion);
    }

    return jsonData;
}