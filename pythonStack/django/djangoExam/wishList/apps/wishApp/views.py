from django.shortcuts import render, redirect
from django.core.urlresolvers import reverse
from django.contrib import messages
from apps.login_app.models import User
from .models import Wish
from datetime import datetime, date

def wishes(request):
    print("*"*90)
    print("Got to wishes")
    context = {
        'user_info': User.objects.get(id=request.session['id']),
        'my_wishes': Wish.objects.filter(wished_by=request.session['id']).filter(granted__isnull=True),
        'granted_wishes': Wish.objects.filter(granted__isnull=False),
    }
    print(Wish.objects.filter(wished_by=request.session['id']).filter(granted__isnull=True))
    return render(request, "wishApp/wishes.html", context)

def new(request):
    print("*"*50)
    print("New wish")
    context = {
        'user_info': User.objects.get(id=request.session['id']),
    }
    return render(request, "wishApp/new.html", context)

def create(request):
    print("*"*50)
    print("Create wish")
    errors = Wish.objects.add_validator(request.POST)
    print(errors)
    if len(errors) > 0:
        for key, value in errors.items():
            messages.error(request, value, extra_tags=key)
        return redirect('./new')
    else:
        user = User.objects.get(id=request.session['id'])
        new_wish = Wish.objects.create(item=request.POST['wish'], description=request.POST['desc'], wished_by=user)
        print(new_wish)
    return redirect(reverse("wish:wishes"))

def edit(request, id):
    print("*"*90)
    print("Edit wish")
    #Validation that wish is in user's account
    user = User.objects.get(id=request.session['id'])
    user_wishes = Wish.objects.filter(wished_by=user)
    print(user_wishes)
    for wish in user_wishes:
        print(wish)
        print(wish.id)
        print(id)
        if int(wish.id) == int(id):
            context = {
                'user_info': User.objects.get(id=request.session['id']),
                'wish_info': Wish.objects.get(id=id),
                'wish_id' : id
            }

            return render(request, "wishApp/edit.html", context)
    return redirect(reverse("wish:wishes"))
            

def update(request):
    print("*"*90)
    print("update wish")
    wish_id = request.POST['wish_id']
    errors = Wish.objects.update_validator(request.POST)
    print(errors)
    if len(errors) > 0:
        for key, value in errors.items():
            messages.error(request, value, extra_tags=key)
        return redirect( reverse('wish:edit', kwargs={'id' : wish_id}))
    else:
        wish_to_update = Wish.objects.get(id=wish_id)
        print(wish_to_update)
        wish_to_update.item = request.POST['wish']
        wish_to_update.description = request.POST['desc']
        wish_to_update.save()
    return redirect(reverse("wish:wishes"))


def delete(request, id):
    print("*"*90)
    print("delete book")
    #Validation it is user's wish
    user = User.objects.get(id=request.session['id'])
    user_wishes = Wish.objects.filter(wished_by=user)
    for wish in user_wishes:
        if int(wish.id) == int(id):
            wish_to_delete = Wish.objects.get(id=id)
            wish_to_delete.delete()
    return redirect(reverse("wish:wishes"))

def grant(request, id):
    print("*"*90)
    print("Wish Granted")
    #Validation it is user's wish
    user = User.objects.get(id=request.session['id'])
    user_wishes = Wish.objects.filter(wished_by=user)
    for wish in user_wishes:
        if int(wish.id) == int(id):
            wish_to_grant = Wish.objects.get(id=id)
            wish_to_grant.granted = date.today()
            wish_to_grant.save()
    return redirect(reverse("wish:wishes"))

def like(request, id):
    print("*"*90)
    print("Wish Liked")
        #Validation it is user's wish
    this_wish = Wish.objects.get(id=id)
    this_user = User.objects.get(id=request.session['id'])
    this_wish.likes.add(this_user)
    return redirect(reverse("wish:wishes"))

def stats(request):
    print("*"*90)
    print("Stats Page")
    user = User.objects.get(id=request.session['id'])
    context = {
        'user_info': User.objects.get(id=request.session['id']),
        'granted_query': Wish.objects.exclude(granted__isnull=True),
        'user_granted': Wish.objects.filter(wished_by=user).exclude(granted__isnull=True),
        'user_pending': Wish.objects.filter(wished_by=user).filter(granted__isnull=True),
    }
    return render(request, "wishApp/stats.html", context)


# Create your views here.
