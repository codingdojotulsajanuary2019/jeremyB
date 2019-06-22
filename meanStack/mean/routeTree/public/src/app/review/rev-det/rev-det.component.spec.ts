import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { RevDetComponent } from './rev-det.component';

describe('RevDetComponent', () => {
  let component: RevDetComponent;
  let fixture: ComponentFixture<RevDetComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ RevDetComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(RevDetComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
