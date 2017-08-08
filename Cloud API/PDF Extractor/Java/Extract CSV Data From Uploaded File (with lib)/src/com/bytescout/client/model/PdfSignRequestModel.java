/*
 * bytescout.io
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 2017-05-11T04:47:23Z
 * 
 *
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen.git
 * Do not edit the class manually.
 */


package com.bytescout.client.model;

import java.util.Objects;
import com.bytescout.client.model.PdfSignRequestModelAnnotations;
import com.bytescout.client.model.PdfSignRequestModelImages;
import com.google.gson.annotations.SerializedName;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;
import java.util.ArrayList;
import java.util.List;

/**
 * Representation of PDF signing request data.
 */
@ApiModel(description = "Representation of PDF signing request data.")
@javax.annotation.Generated(value = "io.swagger.codegen.languages.JavaClientCodegen", date = "2017-05-11T14:49:35.132Z")
public class PdfSignRequestModel {
  @SerializedName("name")
  private String name = null;

  @SerializedName("url")
  private String url = null;

  @SerializedName("images")
  private List<PdfSignRequestModelImages> images = new ArrayList<PdfSignRequestModelImages>();

  @SerializedName("annotations")
  private List<PdfSignRequestModelAnnotations> annotations = new ArrayList<PdfSignRequestModelAnnotations>();

  public PdfSignRequestModel name(String name) {
    this.name = name;
    return this;
  }

   /**
   * File name for the generated result
   * @return name
  **/
  @ApiModelProperty(example = "null", value = "File name for the generated result")
  public String getName() {
    return name;
  }

  public void setName(String name) {
    this.name = name;
  }

  public PdfSignRequestModel url(String url) {
    this.url = url;
    return this;
  }

   /**
   * URL of the source PDF file
   * @return url
  **/
  @ApiModelProperty(example = "null", value = "URL of the source PDF file")
  public String getUrl() {
    return url;
  }

  public void setUrl(String url) {
    this.url = url;
  }

  public PdfSignRequestModel images(List<PdfSignRequestModelImages> images) {
    this.images = images;
    return this;
  }

  public PdfSignRequestModel addImagesItem(PdfSignRequestModelImages imagesItem) {
    this.images.add(imagesItem);
    return this;
  }

   /**
   * Image signatures to add
   * @return images
  **/
  @ApiModelProperty(example = "null", value = "Image signatures to add")
  public List<PdfSignRequestModelImages> getImages() {
    return images;
  }

  public void setImages(List<PdfSignRequestModelImages> images) {
    this.images = images;
  }

  public PdfSignRequestModel annotations(List<PdfSignRequestModelAnnotations> annotations) {
    this.annotations = annotations;
    return this;
  }

  public PdfSignRequestModel addAnnotationsItem(PdfSignRequestModelAnnotations annotationsItem) {
    this.annotations.add(annotationsItem);
    return this;
  }

   /**
   * Annotation (textual) signatures to add
   * @return annotations
  **/
  @ApiModelProperty(example = "null", value = "Annotation (textual) signatures to add")
  public List<PdfSignRequestModelAnnotations> getAnnotations() {
    return annotations;
  }

  public void setAnnotations(List<PdfSignRequestModelAnnotations> annotations) {
    this.annotations = annotations;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    PdfSignRequestModel pdfSignRequestModel = (PdfSignRequestModel) o;
    return Objects.equals(this.name, pdfSignRequestModel.name) &&
        Objects.equals(this.url, pdfSignRequestModel.url) &&
        Objects.equals(this.images, pdfSignRequestModel.images) &&
        Objects.equals(this.annotations, pdfSignRequestModel.annotations);
  }

  @Override
  public int hashCode() {
    return Objects.hash(name, url, images, annotations);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class PdfSignRequestModel {\n");
    
    sb.append("    name: ").append(toIndentedString(name)).append("\n");
    sb.append("    url: ").append(toIndentedString(url)).append("\n");
    sb.append("    images: ").append(toIndentedString(images)).append("\n");
    sb.append("    annotations: ").append(toIndentedString(annotations)).append("\n");
    sb.append("}");
    return sb.toString();
  }

  /**
   * Convert the given object to string with each line indented by 4 spaces
   * (except the first line).
   */
  private String toIndentedString(java.lang.Object o) {
    if (o == null) {
      return "null";
    }
    return o.toString().replace("\n", "\n    ");
  }
  
}

