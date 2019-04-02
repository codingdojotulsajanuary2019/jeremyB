$(document).ready(function(){
    var score = 0;
    $("li.score").html('Score: '+ score);
    $.get("https://opentdb.com/api.php?amount=3&category=17&difficulty=medium&type=multiple", function(scienceData){
        console.log(scienceData);
        
        $(document).on("click", "p.sq1", function(){
            quest1 = scienceData.results[0].question;
            q1ans1 = scienceData.results[0].correct_answer;
            q1ans2 = scienceData.results[0].incorrect_answers[0];
            q1ans3 = scienceData.results[0].incorrect_answers[1];
            q1ans4 = scienceData.results[0].incorrect_answers[2];
            $('p.sq1').html(quest1);
            $('div.sq1a1').html('<button class=" btn sq1a1 correct">'+q1ans1+'</button>');
            $('div.sq1a2').html('<button class=" btn sq1a2">'+q1ans2+'</button>');
            $('div.sq1a3').html('<button class=" btn sq1a3">'+q1ans3+'</button>');
            $('div.sq1a4').html('<button class=" btn sq1a4">'+q1ans4+'</button>');
        });
        
        $(document).on("click", "p.sq2", function(){
            quest2 = scienceData.results[1].question;
            q2ans1 = scienceData.results[1].correct_answer;
            q2ans2 = scienceData.results[1].incorrect_answers[0];
            q2ans3 = scienceData.results[1].incorrect_answers[1];
            q2ans4 = scienceData.results[1].incorrect_answers[2];
            $('p.sq2').html(quest2);
            $('div.sq2a1').html('<button class=" btn sq2a1 correct">'+q2ans1+'</button>');
            $('div.sq2a2').html('<button class=" btn sq2a2">'+q2ans2+'</button>');
            $('div.sq2a3').html('<button class=" btn sq2a3">'+q2ans3+'</button>');
            $('div.sq2a4').html('<button class=" btn sq2a4">'+q2ans4+'</button>');
        });
        
        $(document).on("click", "p.sq3", function(){
            quest3 = scienceData.results[2].question;
            q3ans1 = scienceData.results[2].correct_answer;
            q3ans2 = scienceData.results[2].incorrect_answers[0];
            q3ans3 = scienceData.results[2].incorrect_answers[1];
            q3ans4 = scienceData.results[2].incorrect_answers[2];
            $('p.sq3').html(quest3);
            $('div.sq3a1').html('<button class="btn sq3a1 correct">'+q3ans1+'</button>');
            $('div.sq3a2').html('<button class="btn sq3a2">'+q3ans2+'</button>');
            $('div.sq3a3').html('<button class="btn sq3a3">'+q3ans3+'</button>');
            $('div.sq3a4').html('<button class="btn sq3a4">'+q3ans4+'</button>');
        });

        $("div.sq1").on("click", "button", function(){
            const clicked = $(event.target);
            console.log(clicked.hasClass("correct"));
            if(clicked.hasClass("correct")){
                $('p.sq1').text("Correct!");
                score += 100;
                $("li.score").html('Score: '+ score);
            }
            else{
                $('p.sq1').text("Incorrect!");
                score -= 100;
                $("li.score").html('Score: '+ score);
            }
        });
        $("div.sq2").on("click", "button", function(){
            const clicked = $(event.target);
            console.log(clicked.hasClass("correct"));
            if(clicked.hasClass("correct")){
                $('p.sq2').text("Correct!");
                score += 200;
                $("li.score").html('Score: '+ score);
            }
            else{
                $('p.sq2').text("Incorrect!");
                score -= 200;
                $("li.score").html('Score: '+ score);
            }
        });
        $("div.sq3").on("click", "button", function(){
            const clicked = $(event.target);
            console.log(clicked.hasClass("correct"));
            if(clicked.hasClass("correct")){
                $('p.sq3').text("Correct!");
                score += 300;
                $("li.score").html('Score: '+ score);
            }
            else{
                $('p.sq3').text("Incorrect!");
                score -= 300;
                $("li.score").html('Score: '+ score);
            }
        });
    });
    $.get("https://opentdb.com/api.php?amount=3&category=19&difficulty=medium&type=multiple", function(mathData){
        console.log(mathData);
        $(document).on("click", "p.maq1", function(){
            maquest1 = mathData.results[0].question;
            maq1ans1 = mathData.results[0].correct_answer;
            maq1ans2 = mathData.results[0].incorrect_answers[0];
            maq1ans3 = mathData.results[0].incorrect_answers[1];
            maq1ans4 = mathData.results[0].incorrect_answers[2];
            $('p.maq1').html(maquest1);
            $('div.maq1a1').html('<button class=" btn maq1a1 correct">'+maq1ans1+'</button>');
            $('div.maq1a2').html('<button class=" btn maq1a2">'+maq1ans2+'</button>');
            $('div.maq1a3').html('<button class=" btn maq1a3">'+maq1ans3+'</button>');
            $('div.maq1a4').html('<button class=" btn maq1a4">'+maq1ans4+'</button>');
        });

        $(document).on("click", "p.maq2", function(){
            maquest2 = mathData.results[1].question;
            maq2ans1 = mathData.results[1].correct_answer;
            maq2ans2 = mathData.results[1].incorrect_answers[0];
            maq2ans3 = mathData.results[1].incorrect_answers[1];
            maq2ans4 = mathData.results[1].incorrect_answers[2];
            $('p.maq2').html(maquest2);
            $('div.maq2a1').html('<button class=" btn maq2a1 correct">'+maq2ans1+'</button>');
            $('div.maq2a2').html('<button class=" btn maq2a2">'+maq2ans2+'</button>');
            $('div.maq2a3').html('<button class=" btn maq2a3">'+maq2ans3+'</button>');
            $('div.maq2a4').html('<button class=" btn maq2a4">'+maq2ans4+'</button>');
        });

        $(document).on("click", "p.maq3", function(){
            maquest3 = mathData.results[2].question;
            maq3ans1 = mathData.results[2].correct_answer;
            maq3ans2 = mathData.results[2].incorrect_answers[0];
            maq3ans3 = mathData.results[2].incorrect_answers[1];
            maq3ans4 = mathData.results[2].incorrect_answers[2];
            $('p.maq3').html(maquest3);
            $('div.maq3a1').html('<button class=" btn maq3a1 correct">'+maq3ans1+'</button>');
            $('div.maq3a2').html('<button class=" btn maq3a2">'+maq3ans2+'</button>');
            $('div.maq3a3').html('<button class=" btn maq3a3">'+maq3ans3+'</button>');
            $('div.maq3a4').html('<button class=" btn maq3a4">'+maq3ans4+'</button>');
        });

        $("div.maq1").on("click", "button", function(){
            const clicked = $(event.target);
            console.log(clicked.hasClass("correct"));
            if(clicked.hasClass("correct")){
                $('p.maq1').text("Correct!");
                score += 100;
                $("li.score").html('Score: '+ score);
            }
            else{
                $('p.maq1').text("Incorrect!");
                score -= 100;
                $("li.score").html('Score: '+ score);
            }
        });
        $("div.maq2").on("click", "button", function(){
            const clicked = $(event.target);
            console.log(clicked.hasClass("correct"));
            if(clicked.hasClass("correct")){
                $('p.maq2').text("Correct!");
                score += 200;
                $("li.score").html('Score: '+ score);
            }
            else{
                $('p.maq2').text("Incorrect!");
                score -= 200;
                $("li.score").html('Score: '+ score);
            }
        });
        $("div.maq3").on("click", "button", function(){
            const clicked = $(event.target);
            console.log(clicked.hasClass("correct"));
            if(clicked.hasClass("correct")){
                $('p.maq3').text("Correct!");
                score += 300;
                $("li.score").html('Score: '+ score);
            }
            else{
                $('p.maq3').text("Incorrect!");
                score -= 300;
                $("li.score").html('Score: '+ score);
            }
        });
    });
    $.get("https://opentdb.com/api.php?amount=3&category=20&difficulty=medium&type=multiple", function(mythData){
        console.log(mythData);
        $(document).on("click", "p.myq1", function(){
            myquest1 = mythData.results[0].question;
            myq1ans1 = mythData.results[0].correct_answer;
            myq1ans2 = mythData.results[0].incorrect_answers[0];
            myq1ans3 = mythData.results[0].incorrect_answers[1];
            myq1ans4 = mythData.results[0].incorrect_answers[2];
            $('p.myq1').html(myquest1);
            $('div.myq1a1').html('<button class=" btn myq1a1 correct">'+myq1ans1+'</button>');
            $('div.myq1a2').html('<button class=" btn myq1a2">'+myq1ans2+'</button>');
            $('div.myq1a3').html('<button class=" btn myq1a3">'+myq1ans3+'</button>');
            $('div.myq1a4').html('<button class=" btn myq1a4">'+myq1ans4+'</button>');
        });

        $(document).on("click", "p.myq2", function(){
            myquest2 = mythData.results[1].question;
            myq2ans1 = mythData.results[1].correct_answer;
            myq2ans2 = mythData.results[1].incorrect_answers[0];
            myq2ans3 = mythData.results[1].incorrect_answers[1];
            myq2ans4 = mythData.results[1].incorrect_answers[2];
            $('p.myq2').html(myquest2);
            $('div.myq2a1').html('<button class=" btn myq2a1 correct">'+myq2ans1+'</button>');
            $('div.myq2a2').html('<button class=" btn myq2a2">'+myq2ans2+'</button>');
            $('div.myq2a3').html('<button class=" btn myq2a3">'+myq2ans3+'</button>');
            $('div.myq2a4').html('<button class=" btn myq2a4">'+myq2ans4+'</button>');
        });

        $(document).on("click", "p.myq3", function(){
            myquest3 = mythData.results[2].question;
            myq3ans1 = mythData.results[2].correct_answer;
            myq3ans2 = mythData.results[2].incorrect_answers[0];
            myq3ans3 = mythData.results[2].incorrect_answers[1];
            myq3ans4 = mythData.results[2].incorrect_answers[2];
            $('p.myq3').html(myquest3);
            $('div.myq3a1').html('<button class=" btn myq3a1 correct">'+myq3ans1+'</button>');
            $('div.myq3a2').html('<button class=" btn myq3a2">'+myq3ans2+'</button>');
            $('div.myq3a3').html('<button class=" btn myq3a3">'+myq3ans3+'</button>');
            $('div.myq3a4').html('<button class=" btn myq3a4">'+myq3ans4+'</button>');
        });
        $("div.myq1").on("click", "button", function(){
            const clicked = $(event.target);
            console.log(clicked.hasClass("correct"));
            if(clicked.hasClass("correct")){
                $('p.myq1').text("Correct!");
                score += 100;
                $("li.score").html('Score: '+ score);
            }
            else{
                $('p.myq1').text("Incorrect!");
                score -= 100;
                $("li.score").html('Score: '+ score);
            }
        });
        $("div.myq2").on("click", "button", function(){
            const clicked = $(event.target);
            console.log(clicked.hasClass("correct"));
            if(clicked.hasClass("correct")){
                $('p.myq2').text("Correct!");
                score += 200;
                $("li.score").html('Score: '+ score);
            }
            else{
                $('p.myq2').text("Incorrect!");
                score -= 200;
                $("li.score").html('Score: '+ score);
            }
        });
        $("div.myq3").on("click", "button", function(){
            const clicked = $(event.target);
            console.log(clicked.hasClass("correct"));
            if(clicked.hasClass("correct")){
                $('p.myq3').text("Correct!");
                score += 300;
                $("li.score").html('Score: '+ score);
            }
            else{
                $('p.myq3').text("Incorrect!");
                score -= 300;
                $("li.score").html('Score: '+ score);
            }
        });
    });
    $.get("https://opentdb.com/api.php?amount=3&category=18&difficulty=medium&type=multiple", function(cpuData){
        console.log(cpuData);
        $(document).on("click", "p.cq1", function(){
            cquest1 = cpuData.results[0].question;
            cq1ans1 = cpuData.results[0].correct_answer;
            cq1ans2 = cpuData.results[0].incorrect_answers[0];
            cq1ans3 = cpuData.results[0].incorrect_answers[1];
            cq1ans4 = cpuData.results[0].incorrect_answers[2];
            $('p.cq1').html(cquest1);
            $('div.cq1a1').html('<button class=" btn cq1a1 correct">'+cq1ans1+'</button>');
            $('div.cq1a2').html('<button class=" btn cq1a2">'+cq1ans2+'</button>');
            $('div.cq1a3').html('<button class=" btn cq1a3">'+cq1ans3+'</button>');
            $('div.cq1a4').html('<button class=" btn cq1a4">'+cq1ans4+'</button>');
        });

        $(document).on("click", "p.cq2", function(){
            cquest2 = cpuData.results[1].question;
            cq2ans1 = cpuData.results[1].correct_answer;
            cq2ans2 = cpuData.results[1].incorrect_answers[0];
            cq2ans3 = cpuData.results[1].incorrect_answers[1];
            cq2ans4 = cpuData.results[1].incorrect_answers[2];
            $('p.cq2').html(cquest2);
            $('div.cq2a1').html('<button class=" btn cq2a1 correct">'+cq2ans1+'</button>');
            $('div.cq2a2').html('<button class=" btn cq2a2">'+cq2ans2+'</button>');
            $('div.cq2a3').html('<button class=" btn cq2a3">'+cq2ans3+'</button>');
            $('div.cq2a4').html('<button class=" btn cq2a4">'+cq2ans4+'</button>');
        });

        $(document).on("click", "p.cq3", function(){
            cquest3 = cpuData.results[2].question;
            cq3ans1 = cpuData.results[2].correct_answer;
            cq3ans2 = cpuData.results[2].incorrect_answers[0];
            cq3ans3 = cpuData.results[2].incorrect_answers[1];
            cq3ans4 = cpuData.results[2].incorrect_answers[2];
            $('p.cq3').html(cquest3);
            $('div.cq3a1').html('<button class=" btn cq3a1 correct">'+cq3ans1+'</button>');
            $('div.cq3a2').html('<button class=" btn cq3a2">'+cq3ans2+'</button>');
            $('div.cq3a3').html('<button class=" btn cq3a3">'+cq3ans3+'</button>');
            $('div.cq3a4').html('<button class=" btn cq3a4">'+cq3ans4+'</button>');
        });
        $("div.cq1").on("click", "button", function(){
            const clicked = $(event.target);
            console.log(clicked.hasClass("correct"));
            if(clicked.hasClass("correct")){
                $('p.cq1').text("Correct!");
                score += 100;
                $("li.score").html('Score: '+ score);
            }
            else{
                $('p.cq1').text("Incorrect!");
                score -= 100;
                $("li.score").html('Score: '+ score);
            }
        });
        $("div.cq2").on("click", "button", function(){
            const clicked = $(event.target);
            console.log(clicked.hasClass("correct"));
            if(clicked.hasClass("correct")){
                $('p.cq2').text("Correct!");
                score += 200;
                $("li.score").html('Score: '+ score);
            }
            else{
                $('p.cq2').text("Incorrect!");
                score -= 200;
                $("li.score").html('Score: '+ score);
            }
        });
        $("div.cq3").on("click", "button", function(){
            const clicked = $(event.target);
            console.log(clicked.hasClass("correct"));
            if(clicked.hasClass("correct")){
                $('p.cq3').text("Correct!");
                score += 300;
                $("li.score").html('Score: '+ score);
            }
            else{
                $('p.cq3').text("Incorrect!");
                score -= 300;
                $("li.score").html('Score: '+ score);
            }
        });
    });
});