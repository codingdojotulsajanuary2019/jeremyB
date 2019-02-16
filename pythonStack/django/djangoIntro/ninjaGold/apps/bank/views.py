from django.shortcuts import render, redirect
import random

# Create your views here.
def index(request):
    print("*"*90)
    if 'coinage' not in request.session:
        request.session['coinage']=0
    if 'message' not in request.session:
        request.session['message']=[]
    if 'turn' in request.session:
        request.session['turn'] +=1
    else:
        request.session['turn'] = 0
    print(request.session['message'])
    return render(request, "bank/index.html")

def math(request):
    print(request.POST)
    print("^"*90)
# Farm Logic
    if request.POST['choice'] == 'farm':
        print('Farm was chosen')
        randNum = random.randint(10,20)
        print('Farm check: ', randNum)
        request.session['coinage'] += randNum
        print('gold: ', request.session['coinage'])
        request.session['message'].append("<p>The Farm earned you "+ str(randNum) + " gold.</p>")
        return redirect('/')
# Cave Logic
    elif request.POST['choice'] == 'cave':
        print('Cave was chosen')
        randNum = random.randint(0,30)
        print('Cave check: ', randNum)
        request.session['coinage'] += randNum
        print('gold: ',request.session['coinage'])
        request.session['message'].append("<p>The Cave earned you "+ str(randNum) + " gold.</p>")
        return redirect('/')
# House Logic
    elif request.POST['choice'] == 'house':
        print('House was chosen')
        randNum = 15
        print('House check: ', randNum)
        request.session['coinage'] += randNum
        print('gold: ',request.session['coinage'])
        request.session['message'].append("<p>The House earned you "+ str(randNum) + " gold.</p>")
        return redirect('/')
# Casino Logic
    elif request.POST['choice'] == 'casino':
        print('Casino was chosen')
        randNum = random.randint(-60,90)
        print('Casino check: ', randNum)
        request.session['coinage'] += randNum
        print('gold: ',request.session['coinage'])
        if randNum > 0:
            request.session['message'].append("<p>The Casino earned you "+ str(randNum) + " gold.</p>")
        else:
            request.session['message'].append("<p class='loss_red'>The Casino lost you "+ str(randNum) + " gold.</p>")
        return redirect('/')

    elif request.POST['choice'] == 'reset':
        del request.session['message']
        del request.session['coinage']
        print("Reset Game")
        return redirect('/')
    return redirect('/')