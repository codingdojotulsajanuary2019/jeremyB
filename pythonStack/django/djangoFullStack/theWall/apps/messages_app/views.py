from django.shortcuts import render, redirect
from apps.login_app.models import User
from .models import Message, Comment

# Create your views here.
def wall(request):
    context = {
        'user_info': User.objects.get(id=request.session['id']),
        'messages_query': Message.objects.all(),
        'comments_query': Comment.objects.all()
    }
    return render(request, "messages_app/wall.html", context)

def message(request):
    user = User.objects.get(id=request.session['id'])
    new_message = Message.objects.create(user_id=user, message=request.POST['form_message'])
    print(new_message)
    return redirect('/wall')

def comment(request):
    user = User.objects.get(id=request.session['id'])
    message = Message.objects.get(id=request.POST['message_id'])
    new_comment = Comment.objects.create(message_id=message, user_id=user, comment=request.POST['form_comment'])
    print(new_comment)
    return redirect('/wall')