from django.conf.urls import url
from . import views

urlpatterns = [
    url(r'^wall$', views.wall, name='wall'),
]