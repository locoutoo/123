import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { QuizComponent } from './quiz/quiz.component';
import { QuizListComponent } from './quiz-list/quiz-list.component';
import { QuizEditComponent } from './quiz/quiz-edit.component';
import { QuestionListComponent } from './question-list/question-list.component';
import { QuestionEditComponent } from './question/question-edit.component';
import { AnswerListComponent } from './answer-list/answer-list.component';
import { AnswerEditComponent } from './answer/answer-edit.component';
import { ResultListComponent } from './result-list/result-list.component';
import { ResultEditComponent } from './result/result-edit.component';
import { AboutComponent } from './about/about.component';
import { LoginComponent } from './login/login.component';
import { PageNotFoundComponent } from './pagenotfound/pagenotfound.component';


@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    QuizComponent,
    QuizListComponent,
    QuizEditComponent,
    QuestionListComponent,
    QuestionEditComponent,
    AnswerListComponent,
    AnswerEditComponent,
    ResultListComponent,
    ResultEditComponent,
    AboutComponent,
    LoginComponent,
    PageNotFoundComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },
      { path: 'quiz/create', component: QuizEditComponent },
      { path: 'quiz/edit/:id', component: QuizEditComponent },
      { path: 'quiz/:id', component: QuizComponent },
      { path: 'question/create/:id', component: QuestionEditComponent },
      { path: 'question/edit/:id', component: QuestionEditComponent },
      { path: 'answer/create/:id', component: AnswerEditComponent },
      { path: 'answer/edit/:id', component: AnswerEditComponent },
      { path: 'result/create/:id', component: ResultEditComponent },
      { path: 'result/edit/:id', component: ResultEditComponent },
      { path: 'about', component: AboutComponent },
      { path: 'login', component: LoginComponent },
      { path: '**', component: PageNotFoundComponent }
    ])
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
