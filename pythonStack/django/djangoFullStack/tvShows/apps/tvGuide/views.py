from django.shortcuts import render, redirect
from .models import Show
from django.contrib import messages
# Create your views here.
def index(request):
    return redirect ("/shows")

def shows(request):
    print("*"*90)
    print("Homepage")
    context = {
        "show_table": Show.objects.all()
    }
    return render(request, "tvGuide/index.html", context)

def new(request):
    print("*"*90)
    print("Add New")
    return render(request, "tvGuide/new.html")

def add_new(request):
    print("*"*90)
    print("Creating new show")
    errors = Show.objects.basic_validator(request.POST)
    print(errors)
    if len(errors) > 0:
        for key, value in errors.items():
            messages.error(request, value, extra_tags=key)
        return redirect('/shows/new')
    else: 
        new_show = Show.objects.create(title=request.POST['form_title'], network=request.POST['form_network'], release_date=request.POST['form_date'], description=request.POST['form_desc'])
        id = new_show.id
        return redirect(f"/shows/{id}")

def single_show(request, id):
    print("*"*90)
    print("Showing a single show")
    context = {
        "show_info": Show.objects.get(id=id)
    }
    return render(request, "tvGuide/single_show.html", context)

def edit(request, id):
    print("*"*90)
    print("Edit page")
    context = {
        "show_info": Show.objects.get(id=id)
    }
    get_date = Show.objects.get(id=id)
    print(get_date.release_date)
    return render(request, "tvGuide/edit.html", context)

def update(request, id):
    print("*"*90)
    print("Updating data")
    errors = Show.objects.basic_validator(request.POST)
    print(errors)
    if len(errors) > 0:
        for key, value in errors.items():
            messages.error(request, value, extra_tags=key)
        return redirect('/shows/new')
    else:
        show_to_update = Show.objects.get(id=id)
        show_to_update.title = request.POST['form_title']
        show_to_update.network = request.POST['form_network']
        show_to_update.release_date = request.POST['form_date']
        show_to_update.description = request.POST['form_desc']
        show_to_update.save()
        return redirect(f"/shows/{id}")

def destroy(request, id):
    print("*"*90)
    print("Delete a show from database")
    show_to_delete = Show.objects.get(id=id)
    show_to_delete.delete()
    return redirect("/shows")
