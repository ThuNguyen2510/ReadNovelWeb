import React, { Component } from 'react';
import { Link } from 'react-router-dom';
import Header from './Header';
import 'froala-editor/js/froala_editor.pkgd.min.js';
import 'froala-editor/css/froala_style.min.css';
import 'froala-editor/css/froala_editor.pkgd.min.css';
import FroalaEditor from 'react-froala-wysiwyg';
export class ForumNPost extends Component {
    constructor(props)
    {
        super(props);
        new FroalaEditor('textarea#froala-editor')
    }
    render() {
        
        return (
            <>
                <Header />
                <div className="container">
                    <div className="row">
                        <div className="col-md-12">
                            <div className="phantop">
                                <Link className="pull-left">
                                    <img src="https://bootdey.com/img/Content/user_1.jpg" alt="" className="img-circle" />
                                    <strong>Tên chủ thớt</strong>
                                </Link>
                            </div>

                        </div>
                        <div className="col-md-12">
                            <div className="content">
                                <form className="form">
                                    <p>Tựa đề: </p>
                                    <input className="form-control" type="text" placeholder="Đủ nghĩa - Ngắn gọn - Súc tích" />
                                    <p>Nội dung bài viết</p>
                                    <FroalaEditor></FroalaEditor>

                                </form>
                            </div>
                        </div>
                    </div>
                </div>

            </>
        );
    }
}

export default ForumNPost;
